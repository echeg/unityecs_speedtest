//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C392Component ecsSchmidC392 { get { return (EcsSchmid.C392Component)GetComponent(GameComponentsLookup.EcsSchmidC392); } }
    public bool hasEcsSchmidC392 { get { return HasComponent(GameComponentsLookup.EcsSchmidC392); } }

    public void AddEcsSchmidC392(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC392;
        var component = CreateComponent<EcsSchmid.C392Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC392(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC392;
        var component = CreateComponent<EcsSchmid.C392Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC392() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC392);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC392;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC392 {
        get {
            if (_matcherEcsSchmidC392 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC392);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC392 = matcher;
            }

            return _matcherEcsSchmidC392;
        }
    }
}