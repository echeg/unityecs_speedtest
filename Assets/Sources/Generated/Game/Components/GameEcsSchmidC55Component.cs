//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C55Component ecsSchmidC55 { get { return (EcsSchmid.C55Component)GetComponent(GameComponentsLookup.EcsSchmidC55); } }
    public bool hasEcsSchmidC55 { get { return HasComponent(GameComponentsLookup.EcsSchmidC55); } }

    public void AddEcsSchmidC55(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC55;
        var component = CreateComponent<EcsSchmid.C55Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC55(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC55;
        var component = CreateComponent<EcsSchmid.C55Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC55() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC55);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC55;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC55 {
        get {
            if (_matcherEcsSchmidC55 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC55);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC55 = matcher;
            }

            return _matcherEcsSchmidC55;
        }
    }
}
