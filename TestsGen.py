import os
import argparse
import random
import string

class TestsGen():

    def __init__(self):
        self.ParseInput()
        self.possibleComponentTypes = ["int", "long", "float"]


    def ParseInput(self):

        self.components = 100
        self.systems = 200
        # self.systems - self.systemsReactive = ExecuteSystems\RunSystems
        self.systemsReactive = 150

        self.fieldsInComponent = 2
        self.dir = "output"
        self.filterComponentsCount = 3
        self.entityCount = 1000
        self.componentsOnEntity = 15

        self.GenRandomNames = False
        #print(args.comp)
        #print(args.sys)


    def Run(self):
        random.seed(42)
        # generate components names
        compNames = self.CreateComponentsNames()
        # generate system names
        sysNames = self.CreateSystemsNames()
        # generate random group components for filtres\groups\matchers
        componentsGroups = self.GenerateRandomComponentsArrays(compNames, self.filterComponentsCount, self.systems)
        # generate random group components for entities
        componentsGroups2 = self.GenerateRandomComponentsArrays(compNames, self.componentsOnEntity, self.entityCount)

        cl = self.CreateComponentsLeo(compNames)
        self.SaveToFile(cl,"LeoComponents.cs")
        sl = self.CreateSystemsLeo(compNames, sysNames, componentsGroups)
        self.SaveToFile(sl, "LeoSystems.cs")
        gl = self.CreateLeoSystemRunner(sysNames)
        self.SaveToFile(gl, "LeoRunSystems.cs")
        el = self.CreateLeoEntities(componentsGroups2)
        self.SaveToFile(el, "LeoEntities.cs")

        cs = self.CreateComponentsSchmid(compNames)
        self.SaveToFile(cs, "ShmidComponents.cs")
        ss = self.CreateSystemsShmid(compNames, sysNames, componentsGroups)
        self.SaveToFile(ss, "ShmidSystems.cs")
        gs = self.CreateShmidSystemRunner(sysNames)
        self.SaveToFile(gs, "ShmidRunSystems.cs")
        es = self.CreateShmidEntities(componentsGroups2)
        self.SaveToFile(es, "ShmidEntities.cs")


    def SaveToFile(self, data, filename):
        dir_path = os.path.dirname(os.path.realpath(__file__))
        fullPath = os.path.join(dir_path, self.dir, filename)
        print(fullPath)
        os.makedirs(os.path.dirname(fullPath), exist_ok=True)
        with open(fullPath, 'w') as f:
            f.write(data)


    def GenName(self):
        return ''.join(random.choice(string.ascii_lowercase) for _ in range(16))


    def CreateSystemsNames(self):
        compNames = []
        for i in range(self.systems):
            if self.GenRandomNames:
                sysName = self.GenName()+"System"
            else:
                sysName = "S"+str(i)+"System"
            compNames.append(sysName)

        #print(compNames)
        return compNames


    def CreateComponentsNames(self):
        compNames = []
        for i in range(self.components):
            if self.GenRandomNames:
                comp_name = self.GenName()+"Component"
            else:
                comp_name = "C"+str(i) + "Component"
            compNames.append(comp_name)

        #print(compNames)
        return compNames


    def GenerateRandomComponentsArrays(self, compNames, componentsInArray, arraysCount):
        componentsArrays = []
        for i in range(arraysCount):
            componentsArray = random.sample(compNames, componentsInArray)
            componentsArrays.append(componentsArray)

        return  componentsArrays


    def AddNamespace(self, data, namespace):
        output = "namespace %s { \n\n%s\n }" % (namespace, data)
        return output


    def GenFieldName(self, id):
        return "field"+str(id)

#class WeaponComponent {
#   public int Ammo;
#   public string GunName;
#}
    def CreateComponentsLeo(self, compNames):
        output = ""
        for compName in compNames:
            output += "class %s {\n" % (format(compName),)

            for i in range(self.fieldsInComponent):
                fieldName = self.GenFieldName(i)
                output += " public {0} {1}; \n".format (random.choice(self.possibleComponentTypes), fieldName)

            output += "} \n\n"

        #print (output)
        return self.AddNamespace(output, "EcsLeo")

#    [Game]
#    public sealed class WeaponComponent : IComponent
#    {
#        public int Ammo;
#        public string GunName;
#    }

    def CreateComponentsSchmid(self, compNames):
        output = "using Entitas; \n"

        for compName in compNames:
            output += "[Game]\n"
            output += "public sealed class %s : IComponent {\n" % (format(compName),)

            for i in range(self.fieldsInComponent):
                fieldName = self.GenFieldName(i)
                output += " public {0} {1}; \n".format (random.choice(self.possibleComponentTypes), fieldName)

            output += "} \n\n"

        #print (output)
        return self.AddNamespace(output, "EcsShmid")


# public sealed class TestReactSystem : EcsReactSystem {
#     [EcsWorld]
#     EcsWorld _world;
#
#     [EcsFilterInclude (typeof (WeaponComponent))]
#     EcsFilter _weaponFilter;
#
#     // Should returns filter that react system will watch for.
#     public override EcsFilter GetReactFilter () {
#         return _weaponFilter;
#     }
#
#     // On which event at filter this react-system should be alerted -
#     // "new entity in filter" or "entity inplace update".
#     public override EcsReactSystemType GetReactSystemType () {
#         return EcsReactSystemType.OnUpdate;
#     }
#
#     // EcsReactSystem is IEcsRunSystem and should provides additional info.
#     public override EcsRunSystemType GetRunSystemType () {
#         return EcsRunSystemType.Update;
#     }
#
#     // Filtered entities processing, will be raised only if entities presents.
#     public override void RunReact (List<int> entities) {
#         foreach (var entity in entities) {
#             var weapon = _world.GetComponent<WeaponComponent> (entity);
#             Debug.LogFormat ("Weapon updated on {0}", entity);
#         }
#     }
# }

    def GenerateLeoFilter(self, compNames, filtersCount):
        outputFilter = "[EcsFilterInclude("
        filters = random.sample(compNames, filtersCount)

        for i in range(filtersCount):
            outputFilter +="typeof(%s), " % (filters[i],)

        outputFilter = outputFilter[: -2]
        outputFilter +=")]"

#        outputSum = "var sumFirstField =\n"
#        for i in range(filtersCount):
#            outputSum += "_world.GetComponent<%s>(entity).%s +\n" % (filters[i],self.GenFieldName(0))
#        outputSum = outputSum[:-3]
#        outputSum += ";\n"

        outputSum = "var sumFirstField =_world.GetComponent<%s>(entity).%s +1;\n" % (filters[0],self.GenFieldName(0))
        outputSum +="_world.UpdateComponent<%s>(entity);\n" % (filters[0])

        return outputFilter, outputSum


    def CreateLeoFilterFromGroup(self, filters, filtersCount):
        outputFilter = "[EcsFilterInclude("
        for i in range(filtersCount):
            outputFilter +="typeof(%s), " % (filters[i],)

        outputFilter = outputFilter[: -2]
        outputFilter +=")]"

        return outputFilter


    def CreateLeoSumFromGroup(self, filters):
        outputSum = "var sumFirstField =_world.GetComponent<%s>(entity).%s +1;\n" % (filters[0],self.GenFieldName(0))
        outputSum +="_world.UpdateComponent<%s>(entity);\n" % (filters[0])
        return outputSum


    def CreateSystemsLeo(self, compNames, sysNames, componentsGroups):

        output = "using System.Collections.Generic;\n"
        output += "using LeopotamGroup.Ecs;\n"

        # reactive systems
        for i in range(self.systemsReactive):

            outputFilter = self.CreateLeoFilterFromGroup(componentsGroups[i], self.filterComponentsCount)
            outputSum = self.CreateLeoSumFromGroup(componentsGroups[i])

            sysString =  "public sealed class %s : EcsReactSystem { \n" \
                         "  [EcsWorld] \n" \
                         "  EcsWorld _world; \n\n" \
                         "  %s\n" \
                         "  EcsFilter _filter; \n" \
                         "  public override EcsFilter GetReactFilter () {return _filter;} \n" \
                         "  public override EcsReactSystemType GetReactSystemType () {return EcsReactSystemType.OnUpdate;} \n" \
                         "  public override EcsRunSystemType GetRunSystemType () {return EcsRunSystemType.Update;} \n" \
                         "  public override void RunReact (List<int> entities) { \n" \
                         "      foreach (var entity in entities) { \n" \
                         "%s \n" \
                         "}}}\n\n" % (sysNames[i], outputFilter, outputSum)

            output += sysString

        # run systems
        for i in range(self.systemsReactive, self.systems):

            outputFilter = self.CreateLeoFilterFromGroup(componentsGroups[i], self.filterComponentsCount)
            outputSum = self.CreateLeoSumFromGroup(componentsGroups[i])

            sysString = "public sealed class %s : IEcsRunSystem { \n " \
                        "  [EcsWorld] \n" \
                        "  EcsWorld _world; \n\n" \
                        "  %s\n" \
                        "  EcsFilter _filter; \n" \
                        "  EcsRunSystemType IEcsRunSystem.GetRunSystemType () {return EcsRunSystemType.Update;}\n" \
                        "  void IEcsRunSystem.Run () {\n" \
                        "    foreach (var entity in _filter.Entities) {\n" \
                        "%s\n" \
                        "}\n" \
                        "}}\n" % (sysNames[i], outputFilter, outputSum)

            output += sysString

        #print (output)
        return self.AddNamespace(output, "EcsLeo")


#    public class UnitEndActionPhaseSystem : ReactiveSystem<GameEntity>
#    {
#        public UnitEndActionPhaseSystem(game.GameContext)
#        {
#        }
#
#        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
#        {
#            return context.CreateCollector(GameMatcher.ComponentName);
#        }
#
#        protected override bool Filter(GameEntity entity)
#        {
#            return true;
#        }
#
#        protected override void Execute(List<GameEntity> entities)
#        {
#            foreach (var e in entities){}
#        }
#    }

    def CreateMatcher(self, compNames, filtersCount):
        filters = random.sample(compNames, filtersCount)
        outputFilter = ""
        for i in range(filtersCount):
            outputFilter +="GameMatcher.EcsShmid%s, " % (filters[i][:-9],)
        outputFilter = outputFilter[: -2]

        outputSum = "e.ReplaceEcsShmid%s(e.ecsShmid%s.field0 + 1, 0);" % (filters[0][:-9], filters[0][:-9])
        return outputFilter, outputSum


    def CreateShmidMatcherFromGroup(self, filters, filtersCount):
        outputFilter = ""
        for i in range(filtersCount):
            outputFilter +="GameMatcher.EcsShmid%s, " % (filters[i][:-9],)

        outputFilter = outputFilter[: -2]
        return outputFilter


    def CreateShmidSumFromGroup(self, filters):
        outputSum = "e.ReplaceEcsShmid%s(e.ecsShmid%s.field0 + 1, 0);" % (filters[0][:-9], filters[0][:-9])
        return outputSum


    def CreateSystemsShmid(self, compNames, sysNames, componentsGroups):
        output = "using Entitas; \n"
        output += "using System.Collections.Generic; \n"

        # gen reactive systems
        for i in range(self.systemsReactive):
            outputFilter = self.CreateShmidMatcherFromGroup(componentsGroups[i], self.filterComponentsCount)
            outputSum = self.CreateShmidSumFromGroup(componentsGroups[i])

            sysString = "public class %s : ReactiveSystem<GameEntity> {\n" \
                        "   public %s (GameContext context) : base(Contexts.sharedInstance.game){} \n" \
                        "   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) \n" \
                        "       {return context.CreateCollector(GameMatcher.AllOf(%s));} \n" \
                        "   protected override bool Filter(GameEntity entity) {return true;} \n" \
                        "   protected override void Execute(List<GameEntity> entities) { \n" \
                        "       foreach (var e in entities){ \n" \
                        " %s " \
                        "} \n" \
                        "}} \n" % (sysNames[i], sysNames[i], outputFilter, outputSum)
            output += sysString

        # gen execute systems
        for i in range(self.systemsReactive, self.systems):
            outputFilter = self.CreateShmidMatcherFromGroup(componentsGroups[i], self.filterComponentsCount)
            outputSum = self.CreateShmidSumFromGroup(componentsGroups[i])

            sysString = "public class %s : IExecuteSystem {\n" \
                        "private readonly IGroup<GameEntity> _group;\n" \
                        "public %s (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(%s));}\n " \
                        "public void Execute(){\n" \
                        "  foreach (var e in _group.GetEntities()){\n" \
                        "%s }\n" \
                        "}}\n\n" % (sysNames[i], sysNames[i], outputFilter, outputSum)
            output += sysString

        #print (output)
        return self.AddNamespace(output, "EcsShmid")


#        _world = new EcsWorld ()
#            .AddSystem (new ObstacleProcessing ())
#            .AddSystem (new UserInputProcessing ())
#            .AddSystem (new MovementProcessing ())
#            .AddSystem (new FoodProcessing ())
#            .AddSystem (new DeadProcessing ())
#            .AddSystem (new ScoreProcessing ());
#        _world.Initialize ();

    def CreateLeoSystemRunner(self, sysNames):

        allSys = ""
        output = ""

        for sys in sysNames:
            allSys +="  .Add(new %s())\n" % (sys,)

        output += "using LeopotamGroup.Ecs;\n"
        output += "public class LeoSystemsCreator { \n" \
                 "public static EcsSystems CreateSystems(EcsWorld world){\n" \
                 "  return new EcsSystems(world)\n %s" \
                 ";}\n" \
                 "" % (allSys,)

        output += "}\n"

        return self.AddNamespace(output,"EcsLeo")


    def CreateLeoEntities(self, componentsGroups):
        #comps = random.sample(compNames, self.compOnEntity)

        output = "using LeopotamGroup.Ecs;\n"
        output += "public class LeoEntitiesCreator { \n"
        output += "public static void CreateEntitys(EcsWorld world){\n"
        output += "int  e;\n"
        for i in range(self.entityCount):
            output += "\n  e = world.CreateEntity();\n"
            for comp in componentsGroups[i]:
                output += "  world.AddComponent<%s>(e).field0 = 1;\n" % (comp,)

        output +="}}\n"
        return self.AddNamespace(output,"EcsLeo")


    def CreateShmidSystemRunner(self, sysNames):

        allSys = ""
        output = ""

        for sys in sysNames:
            allSys +="  .Add(new %s(Contexts.sharedInstance.game))\n" % (sys,)

        output += "using Entitas;\n"
        output += "public class ShmidSystemCreator { \n" \
                 "public static Systems CreateSystems(){\n" \
                 "  return new Feature(%s)\n %s" \
                 ";}\n" \
                 "" % ("\"World\"",allSys)

        output += "}\n"

        return self.AddNamespace(output,"EcsShmid")


    def CreateShmidEntities(self, componentsGroups):
       #comps = random.sample(compNames, self.compOnEntity)

        output = "using Entitas;\n"
        output += "public class ShmidEntitiesCreator { \n"
        output += "public static void CreateEntitys(GameContext context){\n"
        output += "GameEntity  e;\n"
        for i in range(self.entityCount):
            output += "\n  e = context.CreateEntity();\n"
            for comp in componentsGroups[i]:
                output += "  e.AddEcsShmid%s(1,1);\n" % (comp[:-9],)
                #output += "  var c = world.AddComponent<%s>(e);\n" % (comp,)
                #output += "  c.%s = 1;\n\n" % (self.GenFieldName(0),)

        output +="}}\n"
        return output

t = TestsGen()
t.Run()

