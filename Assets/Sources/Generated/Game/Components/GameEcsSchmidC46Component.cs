//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C46Component ecsSchmidC46 { get { return (EcsSchmid.C46Component)GetComponent(GameComponentsLookup.EcsSchmidC46); } }
    public bool hasEcsSchmidC46 { get { return HasComponent(GameComponentsLookup.EcsSchmidC46); } }

    public void AddEcsSchmidC46(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC46;
        var component = CreateComponent<EcsSchmid.C46Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC46(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC46;
        var component = CreateComponent<EcsSchmid.C46Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC46() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC46);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC46;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC46 {
        get {
            if (_matcherEcsSchmidC46 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC46);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC46 = matcher;
            }

            return _matcherEcsSchmidC46;
        }
    }
}