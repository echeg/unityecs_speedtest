//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C130Component ecsSchmidC130 { get { return (EcsSchmid.C130Component)GetComponent(GameComponentsLookup.EcsSchmidC130); } }
    public bool hasEcsSchmidC130 { get { return HasComponent(GameComponentsLookup.EcsSchmidC130); } }

    public void AddEcsSchmidC130(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC130;
        var component = CreateComponent<EcsSchmid.C130Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC130(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC130;
        var component = CreateComponent<EcsSchmid.C130Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC130() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC130);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC130;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC130 {
        get {
            if (_matcherEcsSchmidC130 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC130);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC130 = matcher;
            }

            return _matcherEcsSchmidC130;
        }
    }
}