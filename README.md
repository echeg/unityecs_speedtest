# Unity3d ECS Test

The project was created to generate the same code for different ECS and determine their performance.  
Currently supported: [Leopotam/ecs](https://github.com/Leopotam/ecs) and [sschmid/Entitas-CSharp](https://github.com/sschmid/Entitas-CSharp)  
The python is used to generate c# code (components, matchers\filters, systems, reactsystems and observe staff)  

### Usages

You may build Unity Project scene SpeedTest.unity  
Default test data 100 components, 150 react systems, 50 execute systems, 15 component on Entity, 3 component on matcher\fiilter, 2 filed on component and create method for 1000 entity  

### Results

Samsung Note4 - .net 3.5 - mono   
Leo  
Add 1000 entitys 1.189178  
Add 1000 entitys 0.1388092  
Run Iterations_1000 time 3.334839  
Run Iterations_1000 time 2.94664  
Run Iterations_1000 time 2.984146  

sschmid  
Add 1000 entitys 0.9322052  
Add 1000 entitys 0.2367249  
Run Iterations_1000 time 1.015213  
Run Iterations_1000 time 0.9170227  
Run Iterations_1000 time 0.9141693  


### Gen New Test Data

1 Change TestsGen.py  __init__ method.  
2 Run TestsGen.py on Python 3.6  
3 Move files from output folder to Unity.  

For sschmid/Entitas-CSharp you need regenerate code by Roslyn or  
1 remove all prev code  
2 Add Components code (SchmidComponents.cs)  
3 Generate Entitas code  
4 Add Systems code  
