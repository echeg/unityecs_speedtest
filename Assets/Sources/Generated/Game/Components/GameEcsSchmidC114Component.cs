//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C114Component ecsSchmidC114 { get { return (EcsSchmid.C114Component)GetComponent(GameComponentsLookup.EcsSchmidC114); } }
    public bool hasEcsSchmidC114 { get { return HasComponent(GameComponentsLookup.EcsSchmidC114); } }

    public void AddEcsSchmidC114(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC114;
        var component = CreateComponent<EcsSchmid.C114Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC114(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC114;
        var component = CreateComponent<EcsSchmid.C114Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC114() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC114);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC114;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC114 {
        get {
            if (_matcherEcsSchmidC114 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC114);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC114 = matcher;
            }

            return _matcherEcsSchmidC114;
        }
    }
}