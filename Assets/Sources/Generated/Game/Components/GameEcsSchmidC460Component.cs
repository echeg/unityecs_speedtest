//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C460Component ecsSchmidC460 { get { return (EcsSchmid.C460Component)GetComponent(GameComponentsLookup.EcsSchmidC460); } }
    public bool hasEcsSchmidC460 { get { return HasComponent(GameComponentsLookup.EcsSchmidC460); } }

    public void AddEcsSchmidC460(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC460;
        var component = CreateComponent<EcsSchmid.C460Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC460(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC460;
        var component = CreateComponent<EcsSchmid.C460Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC460() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC460);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC460;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC460 {
        get {
            if (_matcherEcsSchmidC460 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC460);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC460 = matcher;
            }

            return _matcherEcsSchmidC460;
        }
    }
}