//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C261Component ecsSchmidC261 { get { return (EcsSchmid.C261Component)GetComponent(GameComponentsLookup.EcsSchmidC261); } }
    public bool hasEcsSchmidC261 { get { return HasComponent(GameComponentsLookup.EcsSchmidC261); } }

    public void AddEcsSchmidC261(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC261;
        var component = CreateComponent<EcsSchmid.C261Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC261(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC261;
        var component = CreateComponent<EcsSchmid.C261Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC261() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC261);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC261;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC261 {
        get {
            if (_matcherEcsSchmidC261 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC261);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC261 = matcher;
            }

            return _matcherEcsSchmidC261;
        }
    }
}