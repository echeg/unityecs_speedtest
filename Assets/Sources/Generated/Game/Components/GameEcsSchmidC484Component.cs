//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C484Component ecsSchmidC484 { get { return (EcsSchmid.C484Component)GetComponent(GameComponentsLookup.EcsSchmidC484); } }
    public bool hasEcsSchmidC484 { get { return HasComponent(GameComponentsLookup.EcsSchmidC484); } }

    public void AddEcsSchmidC484(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC484;
        var component = CreateComponent<EcsSchmid.C484Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC484(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC484;
        var component = CreateComponent<EcsSchmid.C484Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC484() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC484);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC484;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC484 {
        get {
            if (_matcherEcsSchmidC484 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC484);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC484 = matcher;
            }

            return _matcherEcsSchmidC484;
        }
    }
}