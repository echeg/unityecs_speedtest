//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C187Component ecsSchmidC187 { get { return (EcsSchmid.C187Component)GetComponent(GameComponentsLookup.EcsSchmidC187); } }
    public bool hasEcsSchmidC187 { get { return HasComponent(GameComponentsLookup.EcsSchmidC187); } }

    public void AddEcsSchmidC187(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC187;
        var component = CreateComponent<EcsSchmid.C187Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC187(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC187;
        var component = CreateComponent<EcsSchmid.C187Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC187() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC187);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC187;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC187 {
        get {
            if (_matcherEcsSchmidC187 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC187);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC187 = matcher;
            }

            return _matcherEcsSchmidC187;
        }
    }
}