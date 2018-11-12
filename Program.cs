using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Linq;

namespace NugetAssetExtractor
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("USAGE mono NugetAssetExtractor.exe path/to/project.assets.json");
                return;
            }

            string frameworkVersion = "4.6";
            if (args.Length == 2)
                frameworkVersion = args[1];
            
            var jsonObject = JObject.Parse(File.ReadAllText(args[0]));
            var targets = jsonObject["targets"][".NETFramework,Version=v" + frameworkVersion] as IDictionary<string, JToken>;
            if(targets == null)
                return;
            foreach (var target in targets)
            {
                var nameVersion = target.Key.ToLower();
                Console.WriteLine(Path.Combine(nameVersion, "content", "clojure"));
                
                var compileMap = target.Value["compile"] as IDictionary<string, JToken>;
                if (compileMap != null)
                {
                    var compileFiles = compileMap.Keys.Where(k => "_._" != Path.GetFileName(k));
                    foreach (var file in compileFiles)
                        Console.WriteLine(Path.Combine(nameVersion, file));
                }
                
                var runtimeMap = target.Value["runtime"] as IDictionary<string, JToken>;
                if (runtimeMap != null)
                {
                    var runtimeFiles = runtimeMap.Keys.Where(k => "_._" != Path.GetFileName(k));
                    foreach (var file in runtimeFiles)
                        Console.WriteLine(Path.Combine(nameVersion, file));
                }
            }
        }
    }
}