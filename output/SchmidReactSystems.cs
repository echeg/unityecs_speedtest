namespace EcsSchmid { 

using Entitas; 
using System.Collections.Generic; 
public class S0System : ReactiveSystem<GameEntity> {
   public S0System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC14, GameMatcher.EcsSchmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S1System : ReactiveSystem<GameEntity> {
   public S1System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC94, GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S2System : ReactiveSystem<GameEntity> {
   public S2System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC17, GameMatcher.EcsSchmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S3System : ReactiveSystem<GameEntity> {
   public S3System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC86, GameMatcher.EcsSchmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S4System : ReactiveSystem<GameEntity> {
   public S4System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC11, GameMatcher.EcsSchmidC75));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S5System : ReactiveSystem<GameEntity> {
   public S5System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC4, GameMatcher.EcsSchmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S6System : ReactiveSystem<GameEntity> {
   public S6System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC11, GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC29));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S7System : ReactiveSystem<GameEntity> {
   public S7System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC77, GameMatcher.EcsSchmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S8System : ReactiveSystem<GameEntity> {
   public S8System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC71, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC91));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S9System : ReactiveSystem<GameEntity> {
   public S9System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC83, GameMatcher.EcsSchmidC89, GameMatcher.EcsSchmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S10System : ReactiveSystem<GameEntity> {
   public S10System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC53, GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC57));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S11System : ReactiveSystem<GameEntity> {
   public S11System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC0));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S12System : ReactiveSystem<GameEntity> {
   public S12System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S13System : ReactiveSystem<GameEntity> {
   public S13System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC35));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S14System : ReactiveSystem<GameEntity> {
   public S14System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC19, GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC97));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S15System : ReactiveSystem<GameEntity> {
   public S15System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S16System : ReactiveSystem<GameEntity> {
   public S16System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC48, GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC45));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S17System : ReactiveSystem<GameEntity> {
   public S17System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC44, GameMatcher.EcsSchmidC77, GameMatcher.EcsSchmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S18System : ReactiveSystem<GameEntity> {
   public S18System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC5, GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S19System : ReactiveSystem<GameEntity> {
   public S19System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC68, GameMatcher.EcsSchmidC15, GameMatcher.EcsSchmidC48));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S20System : ReactiveSystem<GameEntity> {
   public S20System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S21System : ReactiveSystem<GameEntity> {
   public S21System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S22System : ReactiveSystem<GameEntity> {
   public S22System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC73, GameMatcher.EcsSchmidC24, GameMatcher.EcsSchmidC90));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S23System : ReactiveSystem<GameEntity> {
   public S23System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC5, GameMatcher.EcsSchmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S24System : ReactiveSystem<GameEntity> {
   public S24System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S25System : ReactiveSystem<GameEntity> {
   public S25System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC12));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S26System : ReactiveSystem<GameEntity> {
   public S26System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC48, GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S27System : ReactiveSystem<GameEntity> {
   public S27System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S28System : ReactiveSystem<GameEntity> {
   public S28System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC45, GameMatcher.EcsSchmidC26));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S29System : ReactiveSystem<GameEntity> {
   public S29System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC34, GameMatcher.EcsSchmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S30System : ReactiveSystem<GameEntity> {
   public S30System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC82, GameMatcher.EcsSchmidC9));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S31System : ReactiveSystem<GameEntity> {
   public S31System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC77, GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S32System : ReactiveSystem<GameEntity> {
   public S32System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC68, GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S33System : ReactiveSystem<GameEntity> {
   public S33System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC48));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S34System : ReactiveSystem<GameEntity> {
   public S34System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC34, GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC88));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S35System : ReactiveSystem<GameEntity> {
   public S35System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC71, GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC87));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S36System : ReactiveSystem<GameEntity> {
   public S36System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC41, GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC99));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S37System : ReactiveSystem<GameEntity> {
   public S37System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC4));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S38System : ReactiveSystem<GameEntity> {
   public S38System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC34));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S39System : ReactiveSystem<GameEntity> {
   public S39System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S40System : ReactiveSystem<GameEntity> {
   public S40System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC27));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S41System : ReactiveSystem<GameEntity> {
   public S41System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC83, GameMatcher.EcsSchmidC63, GameMatcher.EcsSchmidC50));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S42System : ReactiveSystem<GameEntity> {
   public S42System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC82, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC18));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S43System : ReactiveSystem<GameEntity> {
   public S43System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC17, GameMatcher.EcsSchmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S44System : ReactiveSystem<GameEntity> {
   public S44System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC95, GameMatcher.EcsSchmidC71, GameMatcher.EcsSchmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S45System : ReactiveSystem<GameEntity> {
   public S45System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC95, GameMatcher.EcsSchmidC74));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S46System : ReactiveSystem<GameEntity> {
   public S46System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC74, GameMatcher.EcsSchmidC51));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S47System : ReactiveSystem<GameEntity> {
   public S47System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC17));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S48System : ReactiveSystem<GameEntity> {
   public S48System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC65, GameMatcher.EcsSchmidC63, GameMatcher.EcsSchmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S49System : ReactiveSystem<GameEntity> {
   public S49System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC96, GameMatcher.EcsSchmidC6, GameMatcher.EcsSchmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S50System : ReactiveSystem<GameEntity> {
   public S50System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC19, GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S51System : ReactiveSystem<GameEntity> {
   public S51System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC76));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S52System : ReactiveSystem<GameEntity> {
   public S52System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC49, GameMatcher.EcsSchmidC48));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S53System : ReactiveSystem<GameEntity> {
   public S53System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S54System : ReactiveSystem<GameEntity> {
   public S54System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC32, GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S55System : ReactiveSystem<GameEntity> {
   public S55System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC92, GameMatcher.EcsSchmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S56System : ReactiveSystem<GameEntity> {
   public S56System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC68, GameMatcher.EcsSchmidC96));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S57System : ReactiveSystem<GameEntity> {
   public S57System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC34, GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC82));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S58System : ReactiveSystem<GameEntity> {
   public S58System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC14, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S59System : ReactiveSystem<GameEntity> {
   public S59System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S60System : ReactiveSystem<GameEntity> {
   public S60System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC0, GameMatcher.EcsSchmidC92, GameMatcher.EcsSchmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S61System : ReactiveSystem<GameEntity> {
   public S61System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC22));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S62System : ReactiveSystem<GameEntity> {
   public S62System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC80));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S63System : ReactiveSystem<GameEntity> {
   public S63System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S64System : ReactiveSystem<GameEntity> {
   public S64System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC77, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S65System : ReactiveSystem<GameEntity> {
   public S65System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S66System : ReactiveSystem<GameEntity> {
   public S66System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC99, GameMatcher.EcsSchmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S67System : ReactiveSystem<GameEntity> {
   public S67System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC0, GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC41));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S68System : ReactiveSystem<GameEntity> {
   public S68System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC2, GameMatcher.EcsSchmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S69System : ReactiveSystem<GameEntity> {
   public S69System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC39, GameMatcher.EcsSchmidC30));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S70System : ReactiveSystem<GameEntity> {
   public S70System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC30, GameMatcher.EcsSchmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S71System : ReactiveSystem<GameEntity> {
   public S71System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC62));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S72System : ReactiveSystem<GameEntity> {
   public S72System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S73System : ReactiveSystem<GameEntity> {
   public S73System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S74System : ReactiveSystem<GameEntity> {
   public S74System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC60, GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S75System : ReactiveSystem<GameEntity> {
   public S75System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC77));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S76System : ReactiveSystem<GameEntity> {
   public S76System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S77System : ReactiveSystem<GameEntity> {
   public S77System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC96, GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC88));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S78System : ReactiveSystem<GameEntity> {
   public S78System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC39));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S79System : ReactiveSystem<GameEntity> {
   public S79System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S80System : ReactiveSystem<GameEntity> {
   public S80System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC56, GameMatcher.EcsSchmidC66));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S81System : ReactiveSystem<GameEntity> {
   public S81System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC57, GameMatcher.EcsSchmidC15, GameMatcher.EcsSchmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S82System : ReactiveSystem<GameEntity> {
   public S82System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S83System : ReactiveSystem<GameEntity> {
   public S83System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC2, GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC70));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S84System : ReactiveSystem<GameEntity> {
   public S84System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC28));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S85System : ReactiveSystem<GameEntity> {
   public S85System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC0, GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC90));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S86System : ReactiveSystem<GameEntity> {
   public S86System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC29));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S87System : ReactiveSystem<GameEntity> {
   public S87System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC4, GameMatcher.EcsSchmidC42));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S88System : ReactiveSystem<GameEntity> {
   public S88System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC65, GameMatcher.EcsSchmidC30));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S89System : ReactiveSystem<GameEntity> {
   public S89System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC62));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S90System : ReactiveSystem<GameEntity> {
   public S90System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC16));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S91System : ReactiveSystem<GameEntity> {
   public S91System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC92, GameMatcher.EcsSchmidC73, GameMatcher.EcsSchmidC60));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S92System : ReactiveSystem<GameEntity> {
   public S92System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC60, GameMatcher.EcsSchmidC52));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S93System : ReactiveSystem<GameEntity> {
   public S93System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC24, GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S94System : ReactiveSystem<GameEntity> {
   public S94System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC45, GameMatcher.EcsSchmidC54));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S95System : ReactiveSystem<GameEntity> {
   public S95System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC52, GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC93));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S96System : ReactiveSystem<GameEntity> {
   public S96System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC6, GameMatcher.EcsSchmidC86, GameMatcher.EcsSchmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S97System : ReactiveSystem<GameEntity> {
   public S97System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC82, GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S98System : ReactiveSystem<GameEntity> {
   public S98System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S99System : ReactiveSystem<GameEntity> {
   public S99System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC24));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S100System : ReactiveSystem<GameEntity> {
   public S100System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC24, GameMatcher.EcsSchmidC68, GameMatcher.EcsSchmidC57));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S101System : ReactiveSystem<GameEntity> {
   public S101System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC17, GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC23));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S102System : ReactiveSystem<GameEntity> {
   public S102System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S103System : ReactiveSystem<GameEntity> {
   public S103System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC56, GameMatcher.EcsSchmidC70));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S104System : ReactiveSystem<GameEntity> {
   public S104System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC6, GameMatcher.EcsSchmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S105System : ReactiveSystem<GameEntity> {
   public S105System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC1, GameMatcher.EcsSchmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S106System : ReactiveSystem<GameEntity> {
   public S106System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC96, GameMatcher.EcsSchmidC30, GameMatcher.EcsSchmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S107System : ReactiveSystem<GameEntity> {
   public S107System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC52, GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC61));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S108System : ReactiveSystem<GameEntity> {
   public S108System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S109System : ReactiveSystem<GameEntity> {
   public S109System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC21, GameMatcher.EcsSchmidC48, GameMatcher.EcsSchmidC0));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S110System : ReactiveSystem<GameEntity> {
   public S110System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC49, GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S111System : ReactiveSystem<GameEntity> {
   public S111System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC36, GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S112System : ReactiveSystem<GameEntity> {
   public S112System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC71, GameMatcher.EcsSchmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S113System : ReactiveSystem<GameEntity> {
   public S113System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S114System : ReactiveSystem<GameEntity> {
   public S114System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC24, GameMatcher.EcsSchmidC37, GameMatcher.EcsSchmidC27));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S115System : ReactiveSystem<GameEntity> {
   public S115System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC74, GameMatcher.EcsSchmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S116System : ReactiveSystem<GameEntity> {
   public S116System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC95));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S117System : ReactiveSystem<GameEntity> {
   public S117System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC6));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S118System : ReactiveSystem<GameEntity> {
   public S118System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC74, GameMatcher.EcsSchmidC61, GameMatcher.EcsSchmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S119System : ReactiveSystem<GameEntity> {
   public S119System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S120System : ReactiveSystem<GameEntity> {
   public S120System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC65, GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC23));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S121System : ReactiveSystem<GameEntity> {
   public S121System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC86));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S122System : ReactiveSystem<GameEntity> {
   public S122System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC30, GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC15));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S123System : ReactiveSystem<GameEntity> {
   public S123System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC72, GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC74));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S124System : ReactiveSystem<GameEntity> {
   public S124System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC5, GameMatcher.EcsSchmidC79));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S125System : ReactiveSystem<GameEntity> {
   public S125System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC53, GameMatcher.EcsSchmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S126System : ReactiveSystem<GameEntity> {
   public S126System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC74, GameMatcher.EcsSchmidC72, GameMatcher.EcsSchmidC66));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S127System : ReactiveSystem<GameEntity> {
   public S127System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC26));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S128System : ReactiveSystem<GameEntity> {
   public S128System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC40));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S129System : ReactiveSystem<GameEntity> {
   public S129System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC30, GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC50));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S130System : ReactiveSystem<GameEntity> {
   public S130System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC82));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S131System : ReactiveSystem<GameEntity> {
   public S131System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC40));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S132System : ReactiveSystem<GameEntity> {
   public S132System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC96, GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S133System : ReactiveSystem<GameEntity> {
   public S133System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S134System : ReactiveSystem<GameEntity> {
   public S134System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S135System : ReactiveSystem<GameEntity> {
   public S135System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S136System : ReactiveSystem<GameEntity> {
   public S136System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC44, GameMatcher.EcsSchmidC8));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S137System : ReactiveSystem<GameEntity> {
   public S137System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC36));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S138System : ReactiveSystem<GameEntity> {
   public S138System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC56, GameMatcher.EcsSchmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S139System : ReactiveSystem<GameEntity> {
   public S139System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC90, GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC78));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S140System : ReactiveSystem<GameEntity> {
   public S140System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC83, GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S141System : ReactiveSystem<GameEntity> {
   public S141System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC38));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S142System : ReactiveSystem<GameEntity> {
   public S142System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC84, GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC17));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S143System : ReactiveSystem<GameEntity> {
   public S143System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC14, GameMatcher.EcsSchmidC13));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S144System : ReactiveSystem<GameEntity> {
   public S144System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC95, GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S145System : ReactiveSystem<GameEntity> {
   public S145System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC34, GameMatcher.EcsSchmidC36, GameMatcher.EcsSchmidC77));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S146System : ReactiveSystem<GameEntity> {
   public S146System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S147System : ReactiveSystem<GameEntity> {
   public S147System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC81));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S148System : ReactiveSystem<GameEntity> {
   public S148System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC62));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S149System : ReactiveSystem<GameEntity> {
   public S149System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC32, GameMatcher.EcsSchmidC6, GameMatcher.EcsSchmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 

 }