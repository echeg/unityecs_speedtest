//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C133Component ecsSchmidC133 { get { return (EcsSchmid.C133Component)GetComponent(GameComponentsLookup.EcsSchmidC133); } }
    public bool hasEcsSchmidC133 { get { return HasComponent(GameComponentsLookup.EcsSchmidC133); } }

    public void AddEcsSchmidC133(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC133;
        var component = CreateComponent<EcsSchmid.C133Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC133(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC133;
        var component = CreateComponent<EcsSchmid.C133Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC133() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC133);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC133;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC133 {
        get {
            if (_matcherEcsSchmidC133 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC133);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC133 = matcher;
            }

            return _matcherEcsSchmidC133;
        }
    }
}