//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C39Component ecsSchmidC39 { get { return (EcsSchmid.C39Component)GetComponent(GameComponentsLookup.EcsSchmidC39); } }
    public bool hasEcsSchmidC39 { get { return HasComponent(GameComponentsLookup.EcsSchmidC39); } }

    public void AddEcsSchmidC39(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC39;
        var component = CreateComponent<EcsSchmid.C39Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC39(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC39;
        var component = CreateComponent<EcsSchmid.C39Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC39() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC39);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC39;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC39 {
        get {
            if (_matcherEcsSchmidC39 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC39);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC39 = matcher;
            }

            return _matcherEcsSchmidC39;
        }
    }
}