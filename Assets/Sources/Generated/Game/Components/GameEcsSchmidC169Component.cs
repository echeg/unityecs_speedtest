//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C169Component ecsSchmidC169 { get { return (EcsSchmid.C169Component)GetComponent(GameComponentsLookup.EcsSchmidC169); } }
    public bool hasEcsSchmidC169 { get { return HasComponent(GameComponentsLookup.EcsSchmidC169); } }

    public void AddEcsSchmidC169(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC169;
        var component = CreateComponent<EcsSchmid.C169Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC169(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC169;
        var component = CreateComponent<EcsSchmid.C169Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC169() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC169);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC169;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC169 {
        get {
            if (_matcherEcsSchmidC169 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC169);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC169 = matcher;
            }

            return _matcherEcsSchmidC169;
        }
    }
}