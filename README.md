Nuget Asset Extractor
=====================

Utility to extract a list of assets from Nuget project.assets.json files

Avoids taking on a dependency to `Newtonsoft.Json` in Arcadia

Usage
-----

```
$ mono NugetAssetExtractor.exe project.assets.json 4.6
lazydata/0.3.2/content/clojure
lazydata/0.3.2/lib/net46/LazyData.dll
lazydata/0.3.2/lib/net46/LazyData.dll
lazydata.json/0.3.2/content/clojure
lazydata.json/0.3.2/lib/net46/LazyData.Json.dll
lazydata.json/0.3.2/lib/net46/LazyData.Json.dll
lazydata.yaml/0.3.2/content/clojure
lazydata.yaml/0.3.2/lib/net46/LazyData.Yaml.dll
lazydata.yaml/0.3.2/lib/net46/LazyData.Yaml.dll
mongodb.bson/2.7.0/content/clojure
mongodb.bson/2.7.0/lib/net45/MongoDB.Bson.dll
mongodb.bson/2.7.0/lib/net45/MongoDB.Bson.dll
nasser.flumbo/1.0.0/content/clojure
newtonsoft.json/8.0.3/content/clojure
newtonsoft.json/8.0.3/lib/net45/Newtonsoft.Json.dll
newtonsoft.json/8.0.3/lib/net45/Newtonsoft.Json.dll
yamldotnet/5.0.1/content/clojure
yamldotnet/5.0.1/lib/net45/YamlDotNet.dll
yamldotnet/5.0.1/lib/net45/YamlDotNet.dll
```

Legal
-----
Copyright © 2018 Tims Gardner and Ramsey Nasser

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this project except in compliance with the License. You may obtain a copy of the License at

```
http://www.apache.org/licenses/LICENSE-2.0
```

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.


