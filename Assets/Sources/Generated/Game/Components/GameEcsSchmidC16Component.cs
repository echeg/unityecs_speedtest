//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C16Component ecsSchmidC16 { get { return (EcsSchmid.C16Component)GetComponent(GameComponentsLookup.EcsSchmidC16); } }
    public bool hasEcsSchmidC16 { get { return HasComponent(GameComponentsLookup.EcsSchmidC16); } }

    public void AddEcsSchmidC16(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC16;
        var component = CreateComponent<EcsSchmid.C16Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC16(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC16;
        var component = CreateComponent<EcsSchmid.C16Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC16() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC16);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC16;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC16 {
        get {
            if (_matcherEcsSchmidC16 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC16);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC16 = matcher;
            }

            return _matcherEcsSchmidC16;
        }
    }
}
