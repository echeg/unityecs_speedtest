//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C348Component ecsSchmidC348 { get { return (EcsSchmid.C348Component)GetComponent(GameComponentsLookup.EcsSchmidC348); } }
    public bool hasEcsSchmidC348 { get { return HasComponent(GameComponentsLookup.EcsSchmidC348); } }

    public void AddEcsSchmidC348(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC348;
        var component = CreateComponent<EcsSchmid.C348Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC348(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC348;
        var component = CreateComponent<EcsSchmid.C348Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC348() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC348);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC348;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC348 {
        get {
            if (_matcherEcsSchmidC348 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC348);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC348 = matcher;
            }

            return _matcherEcsSchmidC348;
        }
    }
}