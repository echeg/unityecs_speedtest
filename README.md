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

Init Leo All Sys 0.3737669
Register Components Creators time 0.05035305
Add Leo entitys 1.882744
Add Leo entitys 0.04458618
Add Leo entitys 0.02714348
Run Leo Single Run time 1.508322
Run Leo Iterations_1000 time 0.7965965
Run Leo Iterations_1000 time 1.028347
Run Leo Iterations_1000 time 0.7501526

Init Schmid All Sys 0.4264908  
Add Schmid entitys 1.385193  
Add Schmid entitys 0.207962  
Add Schmid entitys 0.1805954  
Run Schmid Single Run time 0.2443848  
Run Schmid Iterations_1000 time 0.9331589  
Run Schmid Iterations_1000 time 0.9488602  
Run Schmid Iterations_1000 time 0.9467239  

Sony Z2 - .net 4.6 - mono  

Init Leo All Sys 0.3652186  
Register Components Creators time 0.07050753
dd Leo entitys 2.214939
Add Leo entitys 0.05776405
dd Leo entitys 0.03968811
Run Leo Single Run time 2.483866
Run Leo Iterations_1000 time 1.160664
Run Leo Iterations_1000 time 1.092527
Run Leo Iterations_1000 time 1.124329

Init Schmid All Sys 0.5503559  
Add Schmid entitys 2.360914  
Add Schmid entitys 0.322649  
Add Schmid entitys 0.3149166  
Run Schmid Single Run time 0.2741528  
Run Schmid Iterations_1000 time 1.163706  
Run Schmid Iterations_1000 time 1.165791  
Run Schmid Iterations_1000 time 1.121704  



