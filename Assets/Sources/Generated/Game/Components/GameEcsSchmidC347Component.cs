//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C347Component ecsSchmidC347 { get { return (EcsSchmid.C347Component)GetComponent(GameComponentsLookup.EcsSchmidC347); } }
    public bool hasEcsSchmidC347 { get { return HasComponent(GameComponentsLookup.EcsSchmidC347); } }

    public void AddEcsSchmidC347(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC347;
        var component = CreateComponent<EcsSchmid.C347Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC347(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC347;
        var component = CreateComponent<EcsSchmid.C347Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC347() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC347);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC347;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC347 {
        get {
            if (_matcherEcsSchmidC347 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC347);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC347 = matcher;
            }

            return _matcherEcsSchmidC347;
        }
    }
}