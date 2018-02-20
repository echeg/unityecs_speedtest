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

