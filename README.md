# Unity3d ECS Test

The project was created to generate the same code for different ECS and determine their performance.  
Currently supported: [Leopotam/ecs](https://github.com/Leopotam/ecs) and [sschmid/Entitas-CSharp](https://github.com/sschmid/Entitas-CSharp)  
The python is used to generate c# code (components, matchers\filters, systems, reactsystems and observe staff)  

### Usages

You may build Unity Project scene SpeedTest.unity  
Default test data 100 components, 150 react systems, 50 execute systems, 15 component on Entity, 3 component on matcher\fiilter, 2 filed on component and create method for 1000 entity  

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


### Gen New Test Data

1 Change TestsGen.py  __init__ method.  
2 Run TestsGen.py on Python 3.6  
3 Move files from output folder to Unity.  

For sschmid/Entitas-CSharp you need regenerate code by Roslyn or  
1 remove all prev code  
2 Add Components code (SchmidComponents.cs)  
3 Generate Entitas code  
4 Add Systems code  
