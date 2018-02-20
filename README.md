# Unity3d ECS Test

The project was created to generate the same code for different ECS and determine their performance.  
Currently supported: [Leopotam/ecs](https://github.com/Leopotam/ecs) and [sschmid/Entitas-CSharp](https://github.com/sschmid/Entitas-CSharp)  
The python is used to generate c# code (components, matchers\filters, systems, reactsystems and observe staff)  

### Usages

You may build Unity Project scene SpeedTest.unity  
Default test data 100 components, 150 react systems, 50 execute systems, 15 component on Entity, 3 component on matcher\fiilter, 2 filed on component and create method for 1000 entity  

### Gen New Test Data

1 Change TestsGen.py  __init__ method.  
2 Run TestsGen.py on Python 3.6  
3 Move files from output folder to Unity.  

For sschmid/Entitas-CSharp you need regenerate code by Roslyn or  
1 remove all prev code  
2 Add Components code (SchmidComponents.cs)  
3 Generate Entitas code  
4 Add Systems code  


### Results

Samsung Note4 - .net 4.6 - mono 

Init Leo All Sys 0.3292427  
Register Components Creators time 0.05782318  
Add Leo entitys 1.627518  
Add Leo entitys 0.04668808  
Add Leo entitys 0.05204391  
Run Leo Single Run time 1.292656  
Run Leo Iterations_1000 time 0.8216705  
Run Leo Iterations_1000 time 0.7718582  
Run Leo Iterations_1000 time 0.7668533  

Init Schmid All Sys 0.4264908  
Add Schmid entitys 1.385193  
Add Schmid entitys 0.207962  
Add Schmid entitys 0.1805954  
Run Schmid Single Run time 0.2443848  
Run Schmid Iterations_1000 time 0.9331589  
Run Schmid Iterations_1000 time 0.9488602  
Run Schmid Iterations_1000 time 0.9467239  

Sony Z2 - .net 4.6 - mono  

Init Leo All Sys 0.3697891  
Add Leo entitys 2.928162  
Register Components Creators time 0.08101654  
Add Leo entitys 0.09676743  
Add Leo entitys 0.07318878  
Run Leo Single Run time 2.367935  
Run Leo Iterations_1000 time 1.282661  
Run Leo Iterations_1000 time 1.190426  
Run Leo Iterations_1000 time 1.125175  

Init Schmid All Sys 0.5503559  
Add Schmid entitys 2.360914  
Add Schmid entitys 0.322649  
Add Schmid entitys 0.3149166  
Run Schmid Single Run time 0.2741528  
Run Schmid Iterations_1000 time 1.163706  
Run Schmid Iterations_1000 time 1.165791  
Run Schmid Iterations_1000 time 1.121704  

Nexus 7 2013 - .net 4.6 - mono  

Init Schmid All Sys 0.9919453  
Add Schmid entitys 5.318306  
Add Schmid entitys 0.3611946  
Add Schmid entitys 0.3336716  
Run Schmid Single Run time 0.5344353  
Run Schmid Iterations_1000 time 2.477386  
Run Schmid Iterations_1000 time 2.275867  
Run Schmid Iterations_1000 time 2.476757  

Init Leo All Sys 0.9149895  
Register Components Creators time 0.1374359  
Add Leo entitys 4.183792  
Add Leo entitys 0.09326172  
Add Leo entitys 0.1141663  
Run Leo Single Run time 4.31012  
Run Leo Iterations_1000 time 3.024178  
Run Leo Iterations_1000 time 2.765144  
Run Leo Iterations_1000 time 2.551315  
Run Leo Iterations_1000 time 2.623993  

## Big Test 
self.components = 500  
self.systems = 1000  
self.systemsReactive = 750  
self.fieldsInComponent = 2  
self.dir = "output/Big"  
self.filterComponentsCount = 3  
self.entityCount = 1000  
self.componentsOnEntity = 10  

Sony Z2 Big Test  

02-20 12:31:36.139: I/Unity(15339): Init Schmid All Sys 2.120574  
02-20 12:31:39.248: I/Unity(15339): Add Schmid entitys 1.544062  
02-20 12:31:40.431: I/Unity(15339): Add Schmid entitys 0.2277784  
02-20 12:31:41.411: I/Unity(15339): Add Schmid entitys 0.2135553  
02-20 12:31:42.564: I/Unity(15339): Run Schmid Single Run time 0.2120438  
02-20 12:31:43.957: I/Unity(15339): Run Schmid Iterations_1000 time 0.1561174  
02-20 12:31:44.685: I/Unity(15339): Run Schmid Iterations_1000 time 0.1367321  
02-20 12:31:45.460: I/Unity(15339): Run Schmid Iterations_1000 time 0.1492729  
02-20 12:31:46.614: I/Unity(15339): Add Schmid entitys 0.2705612  
02-20 12:31:47.491: I/Unity(15339): Run Schmid Iterations_1000 time 0.1460304  


02-20 12:31:50.410: I/Unity(15339): Init Leo All Sys 1.696819  
02-20 12:31:53.466: I/Unity(15339): Register Components Creators time 0.3021317  
02-20 12:31:57.744: I/Unity(15339): Add Leo entitys 2.03124  
02-20 12:31:58.692: I/Unity(15339): Add Leo entitys 0.03621101  
02-20 12:31:59.751: I/Unity(15339): Add Leo entitys 0.03777313  
02-20 12:32:07.911: I/Unity(15339): Run Leo Single Run time 6.545662  
02-20 12:32:09.188: I/Unity(15339): Run Leo Iterations_1000 time 0.222374  
02-20 12:32:10.046: I/Unity(15339): Run Leo Iterations_1000 time 0.1483765  
02-20 12:32:10.864: I/Unity(15339): Run Leo Iterations_1000 time 0.1639252  
02-20 12:32:24.873: I/Unity(15339): Add Leo entitys 0.03464127  
02-20 12:32:28.141: I/Unity(15339): Run Leo Iterations_1000 time 2.089664  

Samsung Note 4 Big Test

02-20 12:34:20.229: I/Unity(3444): Init Schmid All Sys 1.70809  
02-20 12:34:24.884: I/Unity(3444): Add Schmid entitys 1.414608  
02-20 12:34:25.704: I/Unity(3444): Add Schmid entitys 0.1465473  
02-20 12:34:26.524: I/Unity(3444): Add Schmid entitys 0.1306496  
02-20 12:34:27.594: I/Unity(3444): Run Schmid Single Run time 0.1625137  
02-20 12:34:28.534: I/Unity(3444): Run Schmid Iterations_1000 time 0.1292324  
02-20 12:34:29.354: I/Unity(3444): Run Schmid Iterations_1000 time 0.1142139  
02-20 12:34:30.144: I/Unity(3444): Run Schmid Iterations_1000 time 0.1136036  
02-20 12:34:31.314: I/Unity(3444): Add Schmid entitys 0.1330109  
02-20 12:34:32.279: I/Unity(3444): Run Schmid Iterations_1000 time 0.1275177  

02-20 12:34:35.009: I/Unity(3444): Init Leo All Sys 1.433708  
02-20 12:34:36.234: I/Unity(3444): Register Components Creators time 0.2168274  
02-20 12:34:40.599: I/Unity(3444): Add Leo entitys 1.55175  
02-20 12:34:41.294: I/Unity(3444): Add Leo entitys 0.02160263  
02-20 12:34:42.144: I/Unity(3444): Add Leo entitys 0.03143311  
02-20 12:34:47.889: I/Unity(3444): Run Leo Single Run time 3.481533  
02-20 12:34:48.834: I/Unity(3444): Run Leo Iterations_1000 time 0.1619034  
02-20 12:34:49.644: I/Unity(3444): Run Leo Iterations_1000 time 0.1500702  
02-20 12:34:50.459: I/Unity(3444): Run Leo Iterations_1000 time 0.1484222  
02-20 12:34:51.594: I/Unity(3444): Add Leo entitys 0.02641296  
02-20 12:34:53.719: I/Unity(3444): Run Leo Iterations_1000 time 1.1241531  
02-20 12:34:55.124: I/Unity(3444): Run Leo Iterations_1000 time 0.1544562  
02-20 12:34:57.513: I/Unity(3444): Run Leo Iterations_1000 time 0.1601868
