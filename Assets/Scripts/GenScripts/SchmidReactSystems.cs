namespace EcsSchmid { 

using Entitas; 
using System.Collections.Generic; 
public class S0System : ReactiveSystem<GameEntity> {
   public S0System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC327, GameMatcher.EcsSchmidC57, GameMatcher.EcsSchmidC12));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC379, GameMatcher.EcsSchmidC140, GameMatcher.EcsSchmidC125));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC114, GameMatcher.EcsSchmidC71, GameMatcher.EcsSchmidC377));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC52, GameMatcher.EcsSchmidC346, GameMatcher.EcsSchmidC379));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC456, GameMatcher.EcsSchmidC279, GameMatcher.EcsSchmidC44));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC302, GameMatcher.EcsSchmidC216, GameMatcher.EcsSchmidC16));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC15, GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC111));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC119, GameMatcher.EcsSchmidC258, GameMatcher.EcsSchmidC308));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC287, GameMatcher.EcsSchmidC101));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC366, GameMatcher.EcsSchmidC332, GameMatcher.EcsSchmidC359));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC279, GameMatcher.EcsSchmidC214, GameMatcher.EcsSchmidC112));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC229, GameMatcher.EcsSchmidC301, GameMatcher.EcsSchmidC142));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC414, GameMatcher.EcsSchmidC445, GameMatcher.EcsSchmidC3));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC388, GameMatcher.EcsSchmidC412, GameMatcher.EcsSchmidC81));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC357, GameMatcher.EcsSchmidC216, GameMatcher.EcsSchmidC174));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC110));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC490, GameMatcher.EcsSchmidC390, GameMatcher.EcsSchmidC172));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC52, GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC194));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC49, GameMatcher.EcsSchmidC183, GameMatcher.EcsSchmidC433));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC176, GameMatcher.EcsSchmidC309, GameMatcher.EcsSchmidC135));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC413, GameMatcher.EcsSchmidC22, GameMatcher.EcsSchmidC373));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC235, GameMatcher.EcsSchmidC274, GameMatcher.EcsSchmidC63));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC498, GameMatcher.EcsSchmidC472, GameMatcher.EcsSchmidC193));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC282, GameMatcher.EcsSchmidC150));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC424, GameMatcher.EcsSchmidC321, GameMatcher.EcsSchmidC316));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC453, GameMatcher.EcsSchmidC441, GameMatcher.EcsSchmidC185));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC295, GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC360));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC23, GameMatcher.EcsSchmidC338));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC116, GameMatcher.EcsSchmidC395, GameMatcher.EcsSchmidC148));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC437, GameMatcher.EcsSchmidC119));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC443, GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC194));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC325));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC427, GameMatcher.EcsSchmidC186, GameMatcher.EcsSchmidC83));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC189, GameMatcher.EcsSchmidC181, GameMatcher.EcsSchmidC107));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC343, GameMatcher.EcsSchmidC136, GameMatcher.EcsSchmidC359));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC479, GameMatcher.EcsSchmidC349, GameMatcher.EcsSchmidC331));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC36, GameMatcher.EcsSchmidC311, GameMatcher.EcsSchmidC325));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC273, GameMatcher.EcsSchmidC373));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC125, GameMatcher.EcsSchmidC83, GameMatcher.EcsSchmidC236));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC194, GameMatcher.EcsSchmidC138, GameMatcher.EcsSchmidC473));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC327, GameMatcher.EcsSchmidC352, GameMatcher.EcsSchmidC285));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC112, GameMatcher.EcsSchmidC350, GameMatcher.EcsSchmidC166));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC431, GameMatcher.EcsSchmidC393, GameMatcher.EcsSchmidC397));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC117, GameMatcher.EcsSchmidC420));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC412, GameMatcher.EcsSchmidC161));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC205, GameMatcher.EcsSchmidC137, GameMatcher.EcsSchmidC33));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC108, GameMatcher.EcsSchmidC467, GameMatcher.EcsSchmidC482));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC290, GameMatcher.EcsSchmidC448, GameMatcher.EcsSchmidC367));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC161, GameMatcher.EcsSchmidC108, GameMatcher.EcsSchmidC335));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC255, GameMatcher.EcsSchmidC202, GameMatcher.EcsSchmidC452));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC468, GameMatcher.EcsSchmidC329, GameMatcher.EcsSchmidC234));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC73, GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC71));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC126, GameMatcher.EcsSchmidC381, GameMatcher.EcsSchmidC287));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC275, GameMatcher.EcsSchmidC134, GameMatcher.EcsSchmidC382));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC299, GameMatcher.EcsSchmidC219, GameMatcher.EcsSchmidC459));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC298, GameMatcher.EcsSchmidC204, GameMatcher.EcsSchmidC185));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC112, GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC260));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC252, GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC386));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC24, GameMatcher.EcsSchmidC440, GameMatcher.EcsSchmidC56));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC78, GameMatcher.EcsSchmidC321, GameMatcher.EcsSchmidC81));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC405, GameMatcher.EcsSchmidC348, GameMatcher.EcsSchmidC216));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC32, GameMatcher.EcsSchmidC197));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC195, GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC239));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC270, GameMatcher.EcsSchmidC128, GameMatcher.EcsSchmidC497));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC283, GameMatcher.EcsSchmidC440, GameMatcher.EcsSchmidC482));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC5, GameMatcher.EcsSchmidC348, GameMatcher.EcsSchmidC369));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC349, GameMatcher.EcsSchmidC453));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC274, GameMatcher.EcsSchmidC384, GameMatcher.EcsSchmidC136));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC393, GameMatcher.EcsSchmidC328, GameMatcher.EcsSchmidC174));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC57, GameMatcher.EcsSchmidC150, GameMatcher.EcsSchmidC222));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC1));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC488, GameMatcher.EcsSchmidC369, GameMatcher.EcsSchmidC448));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC368, GameMatcher.EcsSchmidC134, GameMatcher.EcsSchmidC497));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC256, GameMatcher.EcsSchmidC390, GameMatcher.EcsSchmidC91));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC259, GameMatcher.EcsSchmidC467, GameMatcher.EcsSchmidC54));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC445, GameMatcher.EcsSchmidC320, GameMatcher.EcsSchmidC152));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC430, GameMatcher.EcsSchmidC327, GameMatcher.EcsSchmidC259));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC311, GameMatcher.EcsSchmidC101, GameMatcher.EcsSchmidC78));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC191, GameMatcher.EcsSchmidC390, GameMatcher.EcsSchmidC82));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC488, GameMatcher.EcsSchmidC398));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC472, GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC470));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC0, GameMatcher.EcsSchmidC306, GameMatcher.EcsSchmidC165));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC250, GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC57));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC475, GameMatcher.EcsSchmidC185, GameMatcher.EcsSchmidC449));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC425, GameMatcher.EcsSchmidC413, GameMatcher.EcsSchmidC157));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC122, GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC123));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC449, GameMatcher.EcsSchmidC290, GameMatcher.EcsSchmidC484));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC374));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC248, GameMatcher.EcsSchmidC417, GameMatcher.EcsSchmidC35));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC389, GameMatcher.EcsSchmidC272, GameMatcher.EcsSchmidC392));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC65, GameMatcher.EcsSchmidC337));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC243, GameMatcher.EcsSchmidC484, GameMatcher.EcsSchmidC281));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC84, GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC270));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC446, GameMatcher.EcsSchmidC310, GameMatcher.EcsSchmidC216));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC493, GameMatcher.EcsSchmidC108, GameMatcher.EcsSchmidC475));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC386, GameMatcher.EcsSchmidC373));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC353, GameMatcher.EcsSchmidC102, GameMatcher.EcsSchmidC365));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC159, GameMatcher.EcsSchmidC204, GameMatcher.EcsSchmidC343));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC332, GameMatcher.EcsSchmidC191, GameMatcher.EcsSchmidC224));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC460, GameMatcher.EcsSchmidC264, GameMatcher.EcsSchmidC231));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC61, GameMatcher.EcsSchmidC126, GameMatcher.EcsSchmidC115));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC32, GameMatcher.EcsSchmidC173, GameMatcher.EcsSchmidC10));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC301, GameMatcher.EcsSchmidC283, GameMatcher.EcsSchmidC117));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC301, GameMatcher.EcsSchmidC112, GameMatcher.EcsSchmidC3));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC36, GameMatcher.EcsSchmidC362, GameMatcher.EcsSchmidC323));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC30, GameMatcher.EcsSchmidC117, GameMatcher.EcsSchmidC34));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC463, GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC440));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC169, GameMatcher.EcsSchmidC36, GameMatcher.EcsSchmidC263));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC121, GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC342));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC248, GameMatcher.EcsSchmidC109, GameMatcher.EcsSchmidC276));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC370, GameMatcher.EcsSchmidC478));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC451, GameMatcher.EcsSchmidC292, GameMatcher.EcsSchmidC295));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC242, GameMatcher.EcsSchmidC124, GameMatcher.EcsSchmidC401));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC242, GameMatcher.EcsSchmidC413, GameMatcher.EcsSchmidC208));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC48, GameMatcher.EcsSchmidC49));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC337, GameMatcher.EcsSchmidC220, GameMatcher.EcsSchmidC181));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC216, GameMatcher.EcsSchmidC210, GameMatcher.EcsSchmidC239));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC373, GameMatcher.EcsSchmidC27));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC344, GameMatcher.EcsSchmidC334, GameMatcher.EcsSchmidC330));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC206));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC372, GameMatcher.EcsSchmidC173, GameMatcher.EcsSchmidC409));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC441, GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC127));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC274));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC229, GameMatcher.EcsSchmidC71, GameMatcher.EcsSchmidC216));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC236));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC127, GameMatcher.EcsSchmidC447, GameMatcher.EcsSchmidC472));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC413));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC441, GameMatcher.EcsSchmidC438, GameMatcher.EcsSchmidC281));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC333));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC428, GameMatcher.EcsSchmidC7));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC496, GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC474));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC385, GameMatcher.EcsSchmidC434, GameMatcher.EcsSchmidC121));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC208, GameMatcher.EcsSchmidC248));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC246, GameMatcher.EcsSchmidC109, GameMatcher.EcsSchmidC442));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC205, GameMatcher.EcsSchmidC462, GameMatcher.EcsSchmidC30));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC84, GameMatcher.EcsSchmidC194, GameMatcher.EcsSchmidC1));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC199, GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC474));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC401, GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC146));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC216, GameMatcher.EcsSchmidC356, GameMatcher.EcsSchmidC490));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC374, GameMatcher.EcsSchmidC401, GameMatcher.EcsSchmidC284));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC338, GameMatcher.EcsSchmidC367, GameMatcher.EcsSchmidC249));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC151));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC111, GameMatcher.EcsSchmidC495, GameMatcher.EcsSchmidC29));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC296, GameMatcher.EcsSchmidC376, GameMatcher.EcsSchmidC277));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC382, GameMatcher.EcsSchmidC160));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC299));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC244, GameMatcher.EcsSchmidC257, GameMatcher.EcsSchmidC470));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC436, GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC80));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC29, GameMatcher.EcsSchmidC491, GameMatcher.EcsSchmidC260));} 
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
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC41, GameMatcher.EcsSchmidC435, GameMatcher.EcsSchmidC95));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S150System : ReactiveSystem<GameEntity> {
   public S150System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC304, GameMatcher.EcsSchmidC34));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S151System : ReactiveSystem<GameEntity> {
   public S151System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC345, GameMatcher.EcsSchmidC441, GameMatcher.EcsSchmidC120));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S152System : ReactiveSystem<GameEntity> {
   public S152System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC206, GameMatcher.EcsSchmidC61, GameMatcher.EcsSchmidC482));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S153System : ReactiveSystem<GameEntity> {
   public S153System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC455, GameMatcher.EcsSchmidC291, GameMatcher.EcsSchmidC126));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S154System : ReactiveSystem<GameEntity> {
   public S154System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC296, GameMatcher.EcsSchmidC304, GameMatcher.EcsSchmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S155System : ReactiveSystem<GameEntity> {
   public S155System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC317, GameMatcher.EcsSchmidC41, GameMatcher.EcsSchmidC214));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S156System : ReactiveSystem<GameEntity> {
   public S156System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC336, GameMatcher.EcsSchmidC298, GameMatcher.EcsSchmidC289));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S157System : ReactiveSystem<GameEntity> {
   public S157System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC267, GameMatcher.EcsSchmidC161, GameMatcher.EcsSchmidC478));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S158System : ReactiveSystem<GameEntity> {
   public S158System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC133, GameMatcher.EcsSchmidC104, GameMatcher.EcsSchmidC342));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S159System : ReactiveSystem<GameEntity> {
   public S159System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC366, GameMatcher.EcsSchmidC160, GameMatcher.EcsSchmidC122));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S160System : ReactiveSystem<GameEntity> {
   public S160System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC202, GameMatcher.EcsSchmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S161System : ReactiveSystem<GameEntity> {
   public S161System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC343, GameMatcher.EcsSchmidC330, GameMatcher.EcsSchmidC153));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S162System : ReactiveSystem<GameEntity> {
   public S162System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC234, GameMatcher.EcsSchmidC161, GameMatcher.EcsSchmidC475));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S163System : ReactiveSystem<GameEntity> {
   public S163System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC384, GameMatcher.EcsSchmidC479, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S164System : ReactiveSystem<GameEntity> {
   public S164System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC4, GameMatcher.EcsSchmidC234, GameMatcher.EcsSchmidC318));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S165System : ReactiveSystem<GameEntity> {
   public S165System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC288, GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S166System : ReactiveSystem<GameEntity> {
   public S166System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC275, GameMatcher.EcsSchmidC109, GameMatcher.EcsSchmidC259));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S167System : ReactiveSystem<GameEntity> {
   public S167System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC477));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S168System : ReactiveSystem<GameEntity> {
   public S168System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC178, GameMatcher.EcsSchmidC451, GameMatcher.EcsSchmidC35));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S169System : ReactiveSystem<GameEntity> {
   public S169System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC125, GameMatcher.EcsSchmidC189));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S170System : ReactiveSystem<GameEntity> {
   public S170System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC145, GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC224));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S171System : ReactiveSystem<GameEntity> {
   public S171System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC426, GameMatcher.EcsSchmidC278, GameMatcher.EcsSchmidC360));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S172System : ReactiveSystem<GameEntity> {
   public S172System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC313, GameMatcher.EcsSchmidC413));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S173System : ReactiveSystem<GameEntity> {
   public S173System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC334, GameMatcher.EcsSchmidC270, GameMatcher.EcsSchmidC4));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S174System : ReactiveSystem<GameEntity> {
   public S174System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC341, GameMatcher.EcsSchmidC418, GameMatcher.EcsSchmidC283));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S175System : ReactiveSystem<GameEntity> {
   public S175System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC153, GameMatcher.EcsSchmidC477, GameMatcher.EcsSchmidC339));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S176System : ReactiveSystem<GameEntity> {
   public S176System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC53, GameMatcher.EcsSchmidC480, GameMatcher.EcsSchmidC449));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S177System : ReactiveSystem<GameEntity> {
   public S177System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC68, GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC59));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S178System : ReactiveSystem<GameEntity> {
   public S178System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC455, GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC380));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S179System : ReactiveSystem<GameEntity> {
   public S179System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC283, GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC139));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S180System : ReactiveSystem<GameEntity> {
   public S180System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC144, GameMatcher.EcsSchmidC309, GameMatcher.EcsSchmidC107));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S181System : ReactiveSystem<GameEntity> {
   public S181System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC367, GameMatcher.EcsSchmidC175, GameMatcher.EcsSchmidC104));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S182System : ReactiveSystem<GameEntity> {
   public S182System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC324, GameMatcher.EcsSchmidC436));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S183System : ReactiveSystem<GameEntity> {
   public S183System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC258, GameMatcher.EcsSchmidC250));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S184System : ReactiveSystem<GameEntity> {
   public S184System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC128, GameMatcher.EcsSchmidC463, GameMatcher.EcsSchmidC464));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S185System : ReactiveSystem<GameEntity> {
   public S185System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC433, GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC47));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S186System : ReactiveSystem<GameEntity> {
   public S186System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC324, GameMatcher.EcsSchmidC216, GameMatcher.EcsSchmidC424));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S187System : ReactiveSystem<GameEntity> {
   public S187System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC141, GameMatcher.EcsSchmidC22, GameMatcher.EcsSchmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S188System : ReactiveSystem<GameEntity> {
   public S188System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC170, GameMatcher.EcsSchmidC394, GameMatcher.EcsSchmidC66));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S189System : ReactiveSystem<GameEntity> {
   public S189System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC326, GameMatcher.EcsSchmidC134, GameMatcher.EcsSchmidC82));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S190System : ReactiveSystem<GameEntity> {
   public S190System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC379, GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC282));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S191System : ReactiveSystem<GameEntity> {
   public S191System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC361, GameMatcher.EcsSchmidC218, GameMatcher.EcsSchmidC287));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S192System : ReactiveSystem<GameEntity> {
   public S192System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC4, GameMatcher.EcsSchmidC57, GameMatcher.EcsSchmidC38));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S193System : ReactiveSystem<GameEntity> {
   public S193System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC483, GameMatcher.EcsSchmidC452, GameMatcher.EcsSchmidC353));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S194System : ReactiveSystem<GameEntity> {
   public S194System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC462, GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC279));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S195System : ReactiveSystem<GameEntity> {
   public S195System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC18, GameMatcher.EcsSchmidC427, GameMatcher.EcsSchmidC189));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S196System : ReactiveSystem<GameEntity> {
   public S196System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC298, GameMatcher.EcsSchmidC282, GameMatcher.EcsSchmidC75));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S197System : ReactiveSystem<GameEntity> {
   public S197System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC220, GameMatcher.EcsSchmidC65, GameMatcher.EcsSchmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S198System : ReactiveSystem<GameEntity> {
   public S198System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC157, GameMatcher.EcsSchmidC186, GameMatcher.EcsSchmidC460));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S199System : ReactiveSystem<GameEntity> {
   public S199System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC477, GameMatcher.EcsSchmidC407, GameMatcher.EcsSchmidC497));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S200System : ReactiveSystem<GameEntity> {
   public S200System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC440, GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC460));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S201System : ReactiveSystem<GameEntity> {
   public S201System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC183, GameMatcher.EcsSchmidC107, GameMatcher.EcsSchmidC349));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S202System : ReactiveSystem<GameEntity> {
   public S202System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC127, GameMatcher.EcsSchmidC341, GameMatcher.EcsSchmidC52));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S203System : ReactiveSystem<GameEntity> {
   public S203System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC181, GameMatcher.EcsSchmidC399, GameMatcher.EcsSchmidC286));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S204System : ReactiveSystem<GameEntity> {
   public S204System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC452, GameMatcher.EcsSchmidC447, GameMatcher.EcsSchmidC208));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S205System : ReactiveSystem<GameEntity> {
   public S205System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC498, GameMatcher.EcsSchmidC317, GameMatcher.EcsSchmidC383));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S206System : ReactiveSystem<GameEntity> {
   public S206System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC473, GameMatcher.EcsSchmidC476));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S207System : ReactiveSystem<GameEntity> {
   public S207System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC121, GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S208System : ReactiveSystem<GameEntity> {
   public S208System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC499, GameMatcher.EcsSchmidC409, GameMatcher.EcsSchmidC415));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S209System : ReactiveSystem<GameEntity> {
   public S209System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC90, GameMatcher.EcsSchmidC451, GameMatcher.EcsSchmidC211));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S210System : ReactiveSystem<GameEntity> {
   public S210System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC377));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S211System : ReactiveSystem<GameEntity> {
   public S211System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC473, GameMatcher.EcsSchmidC170, GameMatcher.EcsSchmidC400));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S212System : ReactiveSystem<GameEntity> {
   public S212System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC476, GameMatcher.EcsSchmidC210, GameMatcher.EcsSchmidC410));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S213System : ReactiveSystem<GameEntity> {
   public S213System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC342, GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC376));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S214System : ReactiveSystem<GameEntity> {
   public S214System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC415, GameMatcher.EcsSchmidC127, GameMatcher.EcsSchmidC136));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S215System : ReactiveSystem<GameEntity> {
   public S215System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC403, GameMatcher.EcsSchmidC359));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S216System : ReactiveSystem<GameEntity> {
   public S216System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC195, GameMatcher.EcsSchmidC446));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S217System : ReactiveSystem<GameEntity> {
   public S217System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC19, GameMatcher.EcsSchmidC439, GameMatcher.EcsSchmidC240));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S218System : ReactiveSystem<GameEntity> {
   public S218System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC113, GameMatcher.EcsSchmidC102, GameMatcher.EcsSchmidC418));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S219System : ReactiveSystem<GameEntity> {
   public S219System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC470, GameMatcher.EcsSchmidC235, GameMatcher.EcsSchmidC179));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S220System : ReactiveSystem<GameEntity> {
   public S220System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC156, GameMatcher.EcsSchmidC420, GameMatcher.EcsSchmidC407));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S221System : ReactiveSystem<GameEntity> {
   public S221System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC446, GameMatcher.EcsSchmidC116, GameMatcher.EcsSchmidC114));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S222System : ReactiveSystem<GameEntity> {
   public S222System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC337, GameMatcher.EcsSchmidC98));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S223System : ReactiveSystem<GameEntity> {
   public S223System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC204, GameMatcher.EcsSchmidC168, GameMatcher.EcsSchmidC142));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S224System : ReactiveSystem<GameEntity> {
   public S224System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC495));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S225System : ReactiveSystem<GameEntity> {
   public S225System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC395, GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC179));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S226System : ReactiveSystem<GameEntity> {
   public S226System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC328, GameMatcher.EcsSchmidC260, GameMatcher.EcsSchmidC204));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S227System : ReactiveSystem<GameEntity> {
   public S227System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC347, GameMatcher.EcsSchmidC431, GameMatcher.EcsSchmidC274));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S228System : ReactiveSystem<GameEntity> {
   public S228System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC169, GameMatcher.EcsSchmidC480, GameMatcher.EcsSchmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S229System : ReactiveSystem<GameEntity> {
   public S229System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC449, GameMatcher.EcsSchmidC496));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S230System : ReactiveSystem<GameEntity> {
   public S230System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC133, GameMatcher.EcsSchmidC91, GameMatcher.EcsSchmidC297));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S231System : ReactiveSystem<GameEntity> {
   public S231System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC492, GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S232System : ReactiveSystem<GameEntity> {
   public S232System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC222));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S233System : ReactiveSystem<GameEntity> {
   public S233System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC176, GameMatcher.EcsSchmidC373, GameMatcher.EcsSchmidC402));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S234System : ReactiveSystem<GameEntity> {
   public S234System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC160, GameMatcher.EcsSchmidC223, GameMatcher.EcsSchmidC310));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S235System : ReactiveSystem<GameEntity> {
   public S235System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC261, GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC197));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S236System : ReactiveSystem<GameEntity> {
   public S236System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC460, GameMatcher.EcsSchmidC295, GameMatcher.EcsSchmidC97));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S237System : ReactiveSystem<GameEntity> {
   public S237System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC130, GameMatcher.EcsSchmidC22, GameMatcher.EcsSchmidC362));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S238System : ReactiveSystem<GameEntity> {
   public S238System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC223, GameMatcher.EcsSchmidC0, GameMatcher.EcsSchmidC266));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S239System : ReactiveSystem<GameEntity> {
   public S239System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC473, GameMatcher.EcsSchmidC412, GameMatcher.EcsSchmidC275));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S240System : ReactiveSystem<GameEntity> {
   public S240System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC368, GameMatcher.EcsSchmidC481));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S241System : ReactiveSystem<GameEntity> {
   public S241System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC379, GameMatcher.EcsSchmidC377, GameMatcher.EcsSchmidC343));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S242System : ReactiveSystem<GameEntity> {
   public S242System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC100, GameMatcher.EcsSchmidC186, GameMatcher.EcsSchmidC220));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S243System : ReactiveSystem<GameEntity> {
   public S243System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC485, GameMatcher.EcsSchmidC340));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S244System : ReactiveSystem<GameEntity> {
   public S244System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC471, GameMatcher.EcsSchmidC169, GameMatcher.EcsSchmidC319));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S245System : ReactiveSystem<GameEntity> {
   public S245System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC160, GameMatcher.EcsSchmidC339, GameMatcher.EcsSchmidC434));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S246System : ReactiveSystem<GameEntity> {
   public S246System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC63, GameMatcher.EcsSchmidC368, GameMatcher.EcsSchmidC460));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S247System : ReactiveSystem<GameEntity> {
   public S247System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC153, GameMatcher.EcsSchmidC259, GameMatcher.EcsSchmidC158));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S248System : ReactiveSystem<GameEntity> {
   public S248System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC341, GameMatcher.EcsSchmidC209, GameMatcher.EcsSchmidC167));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S249System : ReactiveSystem<GameEntity> {
   public S249System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC206, GameMatcher.EcsSchmidC356, GameMatcher.EcsSchmidC151));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S250System : ReactiveSystem<GameEntity> {
   public S250System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC283, GameMatcher.EcsSchmidC65, GameMatcher.EcsSchmidC98));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S251System : ReactiveSystem<GameEntity> {
   public S251System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC215, GameMatcher.EcsSchmidC340, GameMatcher.EcsSchmidC481));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S252System : ReactiveSystem<GameEntity> {
   public S252System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC194, GameMatcher.EcsSchmidC346, GameMatcher.EcsSchmidC383));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S253System : ReactiveSystem<GameEntity> {
   public S253System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC462, GameMatcher.EcsSchmidC89, GameMatcher.EcsSchmidC315));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S254System : ReactiveSystem<GameEntity> {
   public S254System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC291, GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC207));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S255System : ReactiveSystem<GameEntity> {
   public S255System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC280, GameMatcher.EcsSchmidC426, GameMatcher.EcsSchmidC0));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S256System : ReactiveSystem<GameEntity> {
   public S256System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC155, GameMatcher.EcsSchmidC146, GameMatcher.EcsSchmidC107));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S257System : ReactiveSystem<GameEntity> {
   public S257System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC220, GameMatcher.EcsSchmidC402, GameMatcher.EcsSchmidC296));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S258System : ReactiveSystem<GameEntity> {
   public S258System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC310, GameMatcher.EcsSchmidC335, GameMatcher.EcsSchmidC164));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S259System : ReactiveSystem<GameEntity> {
   public S259System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC238, GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC345));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S260System : ReactiveSystem<GameEntity> {
   public S260System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC109, GameMatcher.EcsSchmidC261, GameMatcher.EcsSchmidC242));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S261System : ReactiveSystem<GameEntity> {
   public S261System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC406, GameMatcher.EcsSchmidC461, GameMatcher.EcsSchmidC491));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S262System : ReactiveSystem<GameEntity> {
   public S262System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC407, GameMatcher.EcsSchmidC376, GameMatcher.EcsSchmidC86));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S263System : ReactiveSystem<GameEntity> {
   public S263System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC337, GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC145));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S264System : ReactiveSystem<GameEntity> {
   public S264System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC263, GameMatcher.EcsSchmidC339, GameMatcher.EcsSchmidC324));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S265System : ReactiveSystem<GameEntity> {
   public S265System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC317, GameMatcher.EcsSchmidC171, GameMatcher.EcsSchmidC47));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S266System : ReactiveSystem<GameEntity> {
   public S266System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC419, GameMatcher.EcsSchmidC487, GameMatcher.EcsSchmidC384));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S267System : ReactiveSystem<GameEntity> {
   public S267System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC120, GameMatcher.EcsSchmidC344, GameMatcher.EcsSchmidC158));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S268System : ReactiveSystem<GameEntity> {
   public S268System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC115, GameMatcher.EcsSchmidC412, GameMatcher.EcsSchmidC101));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S269System : ReactiveSystem<GameEntity> {
   public S269System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC23));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S270System : ReactiveSystem<GameEntity> {
   public S270System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC125, GameMatcher.EcsSchmidC243, GameMatcher.EcsSchmidC312));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S271System : ReactiveSystem<GameEntity> {
   public S271System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC435, GameMatcher.EcsSchmidC393, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S272System : ReactiveSystem<GameEntity> {
   public S272System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC233, GameMatcher.EcsSchmidC212, GameMatcher.EcsSchmidC453));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S273System : ReactiveSystem<GameEntity> {
   public S273System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC322, GameMatcher.EcsSchmidC294, GameMatcher.EcsSchmidC99));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S274System : ReactiveSystem<GameEntity> {
   public S274System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC367, GameMatcher.EcsSchmidC356, GameMatcher.EcsSchmidC196));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S275System : ReactiveSystem<GameEntity> {
   public S275System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC253, GameMatcher.EcsSchmidC204, GameMatcher.EcsSchmidC124));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S276System : ReactiveSystem<GameEntity> {
   public S276System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC335, GameMatcher.EcsSchmidC352));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S277System : ReactiveSystem<GameEntity> {
   public S277System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC2, GameMatcher.EcsSchmidC457, GameMatcher.EcsSchmidC384));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S278System : ReactiveSystem<GameEntity> {
   public S278System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC440, GameMatcher.EcsSchmidC394, GameMatcher.EcsSchmidC453));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S279System : ReactiveSystem<GameEntity> {
   public S279System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC398, GameMatcher.EcsSchmidC217));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S280System : ReactiveSystem<GameEntity> {
   public S280System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC112, GameMatcher.EcsSchmidC90, GameMatcher.EcsSchmidC411));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S281System : ReactiveSystem<GameEntity> {
   public S281System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC490, GameMatcher.EcsSchmidC356, GameMatcher.EcsSchmidC265));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S282System : ReactiveSystem<GameEntity> {
   public S282System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC237, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC285));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S283System : ReactiveSystem<GameEntity> {
   public S283System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC127, GameMatcher.EcsSchmidC469, GameMatcher.EcsSchmidC434));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S284System : ReactiveSystem<GameEntity> {
   public S284System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC233, GameMatcher.EcsSchmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S285System : ReactiveSystem<GameEntity> {
   public S285System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC410, GameMatcher.EcsSchmidC237, GameMatcher.EcsSchmidC341));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S286System : ReactiveSystem<GameEntity> {
   public S286System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC286, GameMatcher.EcsSchmidC304));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S287System : ReactiveSystem<GameEntity> {
   public S287System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC162, GameMatcher.EcsSchmidC486, GameMatcher.EcsSchmidC386));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S288System : ReactiveSystem<GameEntity> {
   public S288System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC456, GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC313));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S289System : ReactiveSystem<GameEntity> {
   public S289System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC417, GameMatcher.EcsSchmidC368, GameMatcher.EcsSchmidC456));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S290System : ReactiveSystem<GameEntity> {
   public S290System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC258, GameMatcher.EcsSchmidC218, GameMatcher.EcsSchmidC425));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S291System : ReactiveSystem<GameEntity> {
   public S291System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC464, GameMatcher.EcsSchmidC280, GameMatcher.EcsSchmidC228));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S292System : ReactiveSystem<GameEntity> {
   public S292System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC459, GameMatcher.EcsSchmidC81, GameMatcher.EcsSchmidC380));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S293System : ReactiveSystem<GameEntity> {
   public S293System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC441, GameMatcher.EcsSchmidC243, GameMatcher.EcsSchmidC230));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S294System : ReactiveSystem<GameEntity> {
   public S294System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC132, GameMatcher.EcsSchmidC384, GameMatcher.EcsSchmidC126));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S295System : ReactiveSystem<GameEntity> {
   public S295System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC430, GameMatcher.EcsSchmidC326, GameMatcher.EcsSchmidC141));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S296System : ReactiveSystem<GameEntity> {
   public S296System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC392, GameMatcher.EcsSchmidC398, GameMatcher.EcsSchmidC266));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S297System : ReactiveSystem<GameEntity> {
   public S297System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC248, GameMatcher.EcsSchmidC320, GameMatcher.EcsSchmidC122));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S298System : ReactiveSystem<GameEntity> {
   public S298System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC140, GameMatcher.EcsSchmidC225, GameMatcher.EcsSchmidC39));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S299System : ReactiveSystem<GameEntity> {
   public S299System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC365, GameMatcher.EcsSchmidC146, GameMatcher.EcsSchmidC120));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S300System : ReactiveSystem<GameEntity> {
   public S300System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC139, GameMatcher.EcsSchmidC171, GameMatcher.EcsSchmidC163));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S301System : ReactiveSystem<GameEntity> {
   public S301System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC457, GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC41));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S302System : ReactiveSystem<GameEntity> {
   public S302System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC70, GameMatcher.EcsSchmidC77, GameMatcher.EcsSchmidC118));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S303System : ReactiveSystem<GameEntity> {
   public S303System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC196, GameMatcher.EcsSchmidC355, GameMatcher.EcsSchmidC78));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S304System : ReactiveSystem<GameEntity> {
   public S304System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC361, GameMatcher.EcsSchmidC109, GameMatcher.EcsSchmidC32));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S305System : ReactiveSystem<GameEntity> {
   public S305System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC212, GameMatcher.EcsSchmidC208, GameMatcher.EcsSchmidC169));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S306System : ReactiveSystem<GameEntity> {
   public S306System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC277, GameMatcher.EcsSchmidC238, GameMatcher.EcsSchmidC212));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S307System : ReactiveSystem<GameEntity> {
   public S307System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC105, GameMatcher.EcsSchmidC426));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S308System : ReactiveSystem<GameEntity> {
   public S308System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC215, GameMatcher.EcsSchmidC199, GameMatcher.EcsSchmidC463));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S309System : ReactiveSystem<GameEntity> {
   public S309System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC394, GameMatcher.EcsSchmidC299, GameMatcher.EcsSchmidC484));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S310System : ReactiveSystem<GameEntity> {
   public S310System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC356, GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC438));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S311System : ReactiveSystem<GameEntity> {
   public S311System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC391, GameMatcher.EcsSchmidC294));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S312System : ReactiveSystem<GameEntity> {
   public S312System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC194, GameMatcher.EcsSchmidC244, GameMatcher.EcsSchmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S313System : ReactiveSystem<GameEntity> {
   public S313System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC482, GameMatcher.EcsSchmidC180, GameMatcher.EcsSchmidC152));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S314System : ReactiveSystem<GameEntity> {
   public S314System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC385, GameMatcher.EcsSchmidC199, GameMatcher.EcsSchmidC436));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S315System : ReactiveSystem<GameEntity> {
   public S315System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC456, GameMatcher.EcsSchmidC488, GameMatcher.EcsSchmidC427));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S316System : ReactiveSystem<GameEntity> {
   public S316System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC214, GameMatcher.EcsSchmidC275, GameMatcher.EcsSchmidC382));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S317System : ReactiveSystem<GameEntity> {
   public S317System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC376, GameMatcher.EcsSchmidC279, GameMatcher.EcsSchmidC409));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S318System : ReactiveSystem<GameEntity> {
   public S318System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC308, GameMatcher.EcsSchmidC459, GameMatcher.EcsSchmidC112));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S319System : ReactiveSystem<GameEntity> {
   public S319System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC249, GameMatcher.EcsSchmidC112, GameMatcher.EcsSchmidC139));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S320System : ReactiveSystem<GameEntity> {
   public S320System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC223, GameMatcher.EcsSchmidC248, GameMatcher.EcsSchmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S321System : ReactiveSystem<GameEntity> {
   public S321System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC199, GameMatcher.EcsSchmidC172, GameMatcher.EcsSchmidC342));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S322System : ReactiveSystem<GameEntity> {
   public S322System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC347, GameMatcher.EcsSchmidC408, GameMatcher.EcsSchmidC207));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S323System : ReactiveSystem<GameEntity> {
   public S323System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC370, GameMatcher.EcsSchmidC84, GameMatcher.EcsSchmidC430));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S324System : ReactiveSystem<GameEntity> {
   public S324System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC239, GameMatcher.EcsSchmidC470, GameMatcher.EcsSchmidC65));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S325System : ReactiveSystem<GameEntity> {
   public S325System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC318, GameMatcher.EcsSchmidC273, GameMatcher.EcsSchmidC13));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S326System : ReactiveSystem<GameEntity> {
   public S326System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC464, GameMatcher.EcsSchmidC201, GameMatcher.EcsSchmidC303));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S327System : ReactiveSystem<GameEntity> {
   public S327System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC288, GameMatcher.EcsSchmidC339, GameMatcher.EcsSchmidC13));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S328System : ReactiveSystem<GameEntity> {
   public S328System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC42, GameMatcher.EcsSchmidC329, GameMatcher.EcsSchmidC219));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S329System : ReactiveSystem<GameEntity> {
   public S329System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC443, GameMatcher.EcsSchmidC236));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S330System : ReactiveSystem<GameEntity> {
   public S330System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC93, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC133));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S331System : ReactiveSystem<GameEntity> {
   public S331System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC194, GameMatcher.EcsSchmidC167, GameMatcher.EcsSchmidC108));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S332System : ReactiveSystem<GameEntity> {
   public S332System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC167, GameMatcher.EcsSchmidC172));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S333System : ReactiveSystem<GameEntity> {
   public S333System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC389, GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC194));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S334System : ReactiveSystem<GameEntity> {
   public S334System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC385, GameMatcher.EcsSchmidC487));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S335System : ReactiveSystem<GameEntity> {
   public S335System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC425, GameMatcher.EcsSchmidC215, GameMatcher.EcsSchmidC129));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S336System : ReactiveSystem<GameEntity> {
   public S336System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC427, GameMatcher.EcsSchmidC41, GameMatcher.EcsSchmidC240));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S337System : ReactiveSystem<GameEntity> {
   public S337System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC9, GameMatcher.EcsSchmidC383, GameMatcher.EcsSchmidC276));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S338System : ReactiveSystem<GameEntity> {
   public S338System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC487, GameMatcher.EcsSchmidC179));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S339System : ReactiveSystem<GameEntity> {
   public S339System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC114, GameMatcher.EcsSchmidC332, GameMatcher.EcsSchmidC35));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S340System : ReactiveSystem<GameEntity> {
   public S340System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC399, GameMatcher.EcsSchmidC490, GameMatcher.EcsSchmidC333));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S341System : ReactiveSystem<GameEntity> {
   public S341System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC386, GameMatcher.EcsSchmidC15));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S342System : ReactiveSystem<GameEntity> {
   public S342System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC486, GameMatcher.EcsSchmidC126, GameMatcher.EcsSchmidC102));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S343System : ReactiveSystem<GameEntity> {
   public S343System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC429, GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC318));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S344System : ReactiveSystem<GameEntity> {
   public S344System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC78, GameMatcher.EcsSchmidC122, GameMatcher.EcsSchmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S345System : ReactiveSystem<GameEntity> {
   public S345System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC242, GameMatcher.EcsSchmidC342, GameMatcher.EcsSchmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S346System : ReactiveSystem<GameEntity> {
   public S346System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC288, GameMatcher.EcsSchmidC485, GameMatcher.EcsSchmidC111));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S347System : ReactiveSystem<GameEntity> {
   public S347System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC238, GameMatcher.EcsSchmidC358, GameMatcher.EcsSchmidC131));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S348System : ReactiveSystem<GameEntity> {
   public S348System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC392, GameMatcher.EcsSchmidC188, GameMatcher.EcsSchmidC85));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S349System : ReactiveSystem<GameEntity> {
   public S349System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC310, GameMatcher.EcsSchmidC493, GameMatcher.EcsSchmidC382));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S350System : ReactiveSystem<GameEntity> {
   public S350System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC367, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC398));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S351System : ReactiveSystem<GameEntity> {
   public S351System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC419, GameMatcher.EcsSchmidC83, GameMatcher.EcsSchmidC493));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S352System : ReactiveSystem<GameEntity> {
   public S352System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC159, GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC296));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S353System : ReactiveSystem<GameEntity> {
   public S353System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC475, GameMatcher.EcsSchmidC159));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S354System : ReactiveSystem<GameEntity> {
   public S354System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC294, GameMatcher.EcsSchmidC346, GameMatcher.EcsSchmidC464));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S355System : ReactiveSystem<GameEntity> {
   public S355System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC490, GameMatcher.EcsSchmidC192, GameMatcher.EcsSchmidC203));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S356System : ReactiveSystem<GameEntity> {
   public S356System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC482, GameMatcher.EcsSchmidC366, GameMatcher.EcsSchmidC101));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S357System : ReactiveSystem<GameEntity> {
   public S357System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC303, GameMatcher.EcsSchmidC353));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S358System : ReactiveSystem<GameEntity> {
   public S358System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC425, GameMatcher.EcsSchmidC321, GameMatcher.EcsSchmidC124));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S359System : ReactiveSystem<GameEntity> {
   public S359System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC52, GameMatcher.EcsSchmidC356, GameMatcher.EcsSchmidC395));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S360System : ReactiveSystem<GameEntity> {
   public S360System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC435, GameMatcher.EcsSchmidC350));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S361System : ReactiveSystem<GameEntity> {
   public S361System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC307, GameMatcher.EcsSchmidC412, GameMatcher.EcsSchmidC61));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S362System : ReactiveSystem<GameEntity> {
   public S362System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC407, GameMatcher.EcsSchmidC289, GameMatcher.EcsSchmidC400));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S363System : ReactiveSystem<GameEntity> {
   public S363System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC21, GameMatcher.EcsSchmidC177, GameMatcher.EcsSchmidC272));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S364System : ReactiveSystem<GameEntity> {
   public S364System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC219, GameMatcher.EcsSchmidC338, GameMatcher.EcsSchmidC189));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S365System : ReactiveSystem<GameEntity> {
   public S365System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC259, GameMatcher.EcsSchmidC331));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S366System : ReactiveSystem<GameEntity> {
   public S366System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC174, GameMatcher.EcsSchmidC6, GameMatcher.EcsSchmidC434));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S367System : ReactiveSystem<GameEntity> {
   public S367System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC215, GameMatcher.EcsSchmidC421, GameMatcher.EcsSchmidC250));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S368System : ReactiveSystem<GameEntity> {
   public S368System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC221, GameMatcher.EcsSchmidC491));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S369System : ReactiveSystem<GameEntity> {
   public S369System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC185, GameMatcher.EcsSchmidC325, GameMatcher.EcsSchmidC456));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S370System : ReactiveSystem<GameEntity> {
   public S370System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC424, GameMatcher.EcsSchmidC235, GameMatcher.EcsSchmidC362));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S371System : ReactiveSystem<GameEntity> {
   public S371System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC78, GameMatcher.EcsSchmidC222, GameMatcher.EcsSchmidC90));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S372System : ReactiveSystem<GameEntity> {
   public S372System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC375, GameMatcher.EcsSchmidC267, GameMatcher.EcsSchmidC494));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S373System : ReactiveSystem<GameEntity> {
   public S373System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC333, GameMatcher.EcsSchmidC138, GameMatcher.EcsSchmidC315));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S374System : ReactiveSystem<GameEntity> {
   public S374System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC413, GameMatcher.EcsSchmidC470, GameMatcher.EcsSchmidC275));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S375System : ReactiveSystem<GameEntity> {
   public S375System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC396, GameMatcher.EcsSchmidC247, GameMatcher.EcsSchmidC238));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S376System : ReactiveSystem<GameEntity> {
   public S376System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC223, GameMatcher.EcsSchmidC422, GameMatcher.EcsSchmidC374));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S377System : ReactiveSystem<GameEntity> {
   public S377System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC303, GameMatcher.EcsSchmidC137, GameMatcher.EcsSchmidC165));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S378System : ReactiveSystem<GameEntity> {
   public S378System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC436, GameMatcher.EcsSchmidC125, GameMatcher.EcsSchmidC425));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S379System : ReactiveSystem<GameEntity> {
   public S379System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC478, GameMatcher.EcsSchmidC44, GameMatcher.EcsSchmidC142));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S380System : ReactiveSystem<GameEntity> {
   public S380System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC451, GameMatcher.EcsSchmidC230, GameMatcher.EcsSchmidC124));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S381System : ReactiveSystem<GameEntity> {
   public S381System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC384, GameMatcher.EcsSchmidC237, GameMatcher.EcsSchmidC291));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S382System : ReactiveSystem<GameEntity> {
   public S382System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC312, GameMatcher.EcsSchmidC342, GameMatcher.EcsSchmidC194));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S383System : ReactiveSystem<GameEntity> {
   public S383System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC172, GameMatcher.EcsSchmidC14, GameMatcher.EcsSchmidC253));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S384System : ReactiveSystem<GameEntity> {
   public S384System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC435, GameMatcher.EcsSchmidC166, GameMatcher.EcsSchmidC93));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S385System : ReactiveSystem<GameEntity> {
   public S385System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC249, GameMatcher.EcsSchmidC108, GameMatcher.EcsSchmidC181));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S386System : ReactiveSystem<GameEntity> {
   public S386System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC408, GameMatcher.EcsSchmidC132, GameMatcher.EcsSchmidC174));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S387System : ReactiveSystem<GameEntity> {
   public S387System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC143, GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC305));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S388System : ReactiveSystem<GameEntity> {
   public S388System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC359, GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC141));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S389System : ReactiveSystem<GameEntity> {
   public S389System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC284, GameMatcher.EcsSchmidC5, GameMatcher.EcsSchmidC264));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S390System : ReactiveSystem<GameEntity> {
   public S390System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC485, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S391System : ReactiveSystem<GameEntity> {
   public S391System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC123, GameMatcher.EcsSchmidC368, GameMatcher.EcsSchmidC208));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S392System : ReactiveSystem<GameEntity> {
   public S392System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC250, GameMatcher.EcsSchmidC284, GameMatcher.EcsSchmidC388));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S393System : ReactiveSystem<GameEntity> {
   public S393System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC123, GameMatcher.EcsSchmidC353, GameMatcher.EcsSchmidC243));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S394System : ReactiveSystem<GameEntity> {
   public S394System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC330, GameMatcher.EcsSchmidC364, GameMatcher.EcsSchmidC251));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S395System : ReactiveSystem<GameEntity> {
   public S395System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC229, GameMatcher.EcsSchmidC405, GameMatcher.EcsSchmidC8));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S396System : ReactiveSystem<GameEntity> {
   public S396System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC47, GameMatcher.EcsSchmidC150, GameMatcher.EcsSchmidC113));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S397System : ReactiveSystem<GameEntity> {
   public S397System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC207, GameMatcher.EcsSchmidC354, GameMatcher.EcsSchmidC124));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S398System : ReactiveSystem<GameEntity> {
   public S398System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC156, GameMatcher.EcsSchmidC339, GameMatcher.EcsSchmidC297));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S399System : ReactiveSystem<GameEntity> {
   public S399System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC188, GameMatcher.EcsSchmidC242, GameMatcher.EcsSchmidC283));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S400System : ReactiveSystem<GameEntity> {
   public S400System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC176, GameMatcher.EcsSchmidC217));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S401System : ReactiveSystem<GameEntity> {
   public S401System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC381, GameMatcher.EcsSchmidC281, GameMatcher.EcsSchmidC169));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S402System : ReactiveSystem<GameEntity> {
   public S402System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC180, GameMatcher.EcsSchmidC359, GameMatcher.EcsSchmidC232));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S403System : ReactiveSystem<GameEntity> {
   public S403System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC138, GameMatcher.EcsSchmidC156, GameMatcher.EcsSchmidC128));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S404System : ReactiveSystem<GameEntity> {
   public S404System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC118, GameMatcher.EcsSchmidC61, GameMatcher.EcsSchmidC369));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S405System : ReactiveSystem<GameEntity> {
   public S405System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC161, GameMatcher.EcsSchmidC61));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S406System : ReactiveSystem<GameEntity> {
   public S406System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC380, GameMatcher.EcsSchmidC274, GameMatcher.EcsSchmidC486));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S407System : ReactiveSystem<GameEntity> {
   public S407System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC390, GameMatcher.EcsSchmidC353, GameMatcher.EcsSchmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S408System : ReactiveSystem<GameEntity> {
   public S408System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC98, GameMatcher.EcsSchmidC110, GameMatcher.EcsSchmidC378));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S409System : ReactiveSystem<GameEntity> {
   public S409System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC247, GameMatcher.EcsSchmidC141, GameMatcher.EcsSchmidC370));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S410System : ReactiveSystem<GameEntity> {
   public S410System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC301, GameMatcher.EcsSchmidC389, GameMatcher.EcsSchmidC268));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S411System : ReactiveSystem<GameEntity> {
   public S411System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC144, GameMatcher.EcsSchmidC51));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S412System : ReactiveSystem<GameEntity> {
   public S412System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC426, GameMatcher.EcsSchmidC99, GameMatcher.EcsSchmidC151));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S413System : ReactiveSystem<GameEntity> {
   public S413System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC116, GameMatcher.EcsSchmidC184, GameMatcher.EcsSchmidC91));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S414System : ReactiveSystem<GameEntity> {
   public S414System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC362));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S415System : ReactiveSystem<GameEntity> {
   public S415System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC273, GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC140));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S416System : ReactiveSystem<GameEntity> {
   public S416System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC23, GameMatcher.EcsSchmidC498, GameMatcher.EcsSchmidC27));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S417System : ReactiveSystem<GameEntity> {
   public S417System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC283, GameMatcher.EcsSchmidC149, GameMatcher.EcsSchmidC357));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S418System : ReactiveSystem<GameEntity> {
   public S418System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC483, GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC326));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S419System : ReactiveSystem<GameEntity> {
   public S419System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC444, GameMatcher.EcsSchmidC385, GameMatcher.EcsSchmidC251));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S420System : ReactiveSystem<GameEntity> {
   public S420System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC52, GameMatcher.EcsSchmidC446, GameMatcher.EcsSchmidC6));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S421System : ReactiveSystem<GameEntity> {
   public S421System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC293, GameMatcher.EcsSchmidC145, GameMatcher.EcsSchmidC240));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S422System : ReactiveSystem<GameEntity> {
   public S422System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC245, GameMatcher.EcsSchmidC225, GameMatcher.EcsSchmidC174));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S423System : ReactiveSystem<GameEntity> {
   public S423System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC94, GameMatcher.EcsSchmidC494, GameMatcher.EcsSchmidC26));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S424System : ReactiveSystem<GameEntity> {
   public S424System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC129, GameMatcher.EcsSchmidC481, GameMatcher.EcsSchmidC441));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S425System : ReactiveSystem<GameEntity> {
   public S425System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC244, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC420));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S426System : ReactiveSystem<GameEntity> {
   public S426System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC33, GameMatcher.EcsSchmidC205, GameMatcher.EcsSchmidC251));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S427System : ReactiveSystem<GameEntity> {
   public S427System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC37, GameMatcher.EcsSchmidC295, GameMatcher.EcsSchmidC322));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S428System : ReactiveSystem<GameEntity> {
   public S428System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC77));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S429System : ReactiveSystem<GameEntity> {
   public S429System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC415, GameMatcher.EcsSchmidC288));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S430System : ReactiveSystem<GameEntity> {
   public S430System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC485, GameMatcher.EcsSchmidC155, GameMatcher.EcsSchmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S431System : ReactiveSystem<GameEntity> {
   public S431System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC127, GameMatcher.EcsSchmidC60, GameMatcher.EcsSchmidC285));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S432System : ReactiveSystem<GameEntity> {
   public S432System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC391, GameMatcher.EcsSchmidC213, GameMatcher.EcsSchmidC310));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S433System : ReactiveSystem<GameEntity> {
   public S433System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC404, GameMatcher.EcsSchmidC316));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S434System : ReactiveSystem<GameEntity> {
   public S434System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC115, GameMatcher.EcsSchmidC397, GameMatcher.EcsSchmidC267));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S435System : ReactiveSystem<GameEntity> {
   public S435System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC194, GameMatcher.EcsSchmidC230, GameMatcher.EcsSchmidC465));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S436System : ReactiveSystem<GameEntity> {
   public S436System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC152, GameMatcher.EcsSchmidC440));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S437System : ReactiveSystem<GameEntity> {
   public S437System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC301, GameMatcher.EcsSchmidC219, GameMatcher.EcsSchmidC156));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S438System : ReactiveSystem<GameEntity> {
   public S438System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC291, GameMatcher.EcsSchmidC317, GameMatcher.EcsSchmidC30));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S439System : ReactiveSystem<GameEntity> {
   public S439System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC312, GameMatcher.EcsSchmidC491, GameMatcher.EcsSchmidC378));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S440System : ReactiveSystem<GameEntity> {
   public S440System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC485, GameMatcher.EcsSchmidC390));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S441System : ReactiveSystem<GameEntity> {
   public S441System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC106, GameMatcher.EcsSchmidC320, GameMatcher.EcsSchmidC108));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S442System : ReactiveSystem<GameEntity> {
   public S442System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC338, GameMatcher.EcsSchmidC41));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S443System : ReactiveSystem<GameEntity> {
   public S443System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC122, GameMatcher.EcsSchmidC88));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S444System : ReactiveSystem<GameEntity> {
   public S444System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC282, GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC80));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S445System : ReactiveSystem<GameEntity> {
   public S445System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC1, GameMatcher.EcsSchmidC209, GameMatcher.EcsSchmidC230));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S446System : ReactiveSystem<GameEntity> {
   public S446System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC352, GameMatcher.EcsSchmidC304, GameMatcher.EcsSchmidC240));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S447System : ReactiveSystem<GameEntity> {
   public S447System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC149, GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC118));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S448System : ReactiveSystem<GameEntity> {
   public S448System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC147, GameMatcher.EcsSchmidC361, GameMatcher.EcsSchmidC144));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S449System : ReactiveSystem<GameEntity> {
   public S449System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC359, GameMatcher.EcsSchmidC440, GameMatcher.EcsSchmidC232));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S450System : ReactiveSystem<GameEntity> {
   public S450System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC36, GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC119));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S451System : ReactiveSystem<GameEntity> {
   public S451System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC473, GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC403));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S452System : ReactiveSystem<GameEntity> {
   public S452System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC405, GameMatcher.EcsSchmidC320, GameMatcher.EcsSchmidC301));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S453System : ReactiveSystem<GameEntity> {
   public S453System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC338, GameMatcher.EcsSchmidC411, GameMatcher.EcsSchmidC478));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S454System : ReactiveSystem<GameEntity> {
   public S454System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC101, GameMatcher.EcsSchmidC217, GameMatcher.EcsSchmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S455System : ReactiveSystem<GameEntity> {
   public S455System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC278, GameMatcher.EcsSchmidC115, GameMatcher.EcsSchmidC331));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S456System : ReactiveSystem<GameEntity> {
   public S456System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC76, GameMatcher.EcsSchmidC465, GameMatcher.EcsSchmidC136));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S457System : ReactiveSystem<GameEntity> {
   public S457System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC423, GameMatcher.EcsSchmidC72, GameMatcher.EcsSchmidC36));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S458System : ReactiveSystem<GameEntity> {
   public S458System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC30, GameMatcher.EcsSchmidC84, GameMatcher.EcsSchmidC405));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S459System : ReactiveSystem<GameEntity> {
   public S459System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC157, GameMatcher.EcsSchmidC304, GameMatcher.EcsSchmidC383));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S460System : ReactiveSystem<GameEntity> {
   public S460System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC422, GameMatcher.EcsSchmidC291, GameMatcher.EcsSchmidC471));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S461System : ReactiveSystem<GameEntity> {
   public S461System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC147, GameMatcher.EcsSchmidC224, GameMatcher.EcsSchmidC63));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S462System : ReactiveSystem<GameEntity> {
   public S462System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC239, GameMatcher.EcsSchmidC352, GameMatcher.EcsSchmidC155));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S463System : ReactiveSystem<GameEntity> {
   public S463System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC358, GameMatcher.EcsSchmidC206, GameMatcher.EcsSchmidC482));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S464System : ReactiveSystem<GameEntity> {
   public S464System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC139, GameMatcher.EcsSchmidC256, GameMatcher.EcsSchmidC276));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S465System : ReactiveSystem<GameEntity> {
   public S465System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC252, GameMatcher.EcsSchmidC224, GameMatcher.EcsSchmidC41));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S466System : ReactiveSystem<GameEntity> {
   public S466System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC306, GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC455));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S467System : ReactiveSystem<GameEntity> {
   public S467System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC221, GameMatcher.EcsSchmidC376, GameMatcher.EcsSchmidC165));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S468System : ReactiveSystem<GameEntity> {
   public S468System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC309, GameMatcher.EcsSchmidC128, GameMatcher.EcsSchmidC13));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S469System : ReactiveSystem<GameEntity> {
   public S469System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC117, GameMatcher.EcsSchmidC492));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S470System : ReactiveSystem<GameEntity> {
   public S470System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC345, GameMatcher.EcsSchmidC428, GameMatcher.EcsSchmidC440));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S471System : ReactiveSystem<GameEntity> {
   public S471System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC294, GameMatcher.EcsSchmidC300, GameMatcher.EcsSchmidC486));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S472System : ReactiveSystem<GameEntity> {
   public S472System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC391, GameMatcher.EcsSchmidC344));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S473System : ReactiveSystem<GameEntity> {
   public S473System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC420, GameMatcher.EcsSchmidC137, GameMatcher.EcsSchmidC295));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S474System : ReactiveSystem<GameEntity> {
   public S474System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC20, GameMatcher.EcsSchmidC390, GameMatcher.EcsSchmidC387));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S475System : ReactiveSystem<GameEntity> {
   public S475System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC89, GameMatcher.EcsSchmidC240, GameMatcher.EcsSchmidC265));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S476System : ReactiveSystem<GameEntity> {
   public S476System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC333, GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC469));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S477System : ReactiveSystem<GameEntity> {
   public S477System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC92, GameMatcher.EcsSchmidC299));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S478System : ReactiveSystem<GameEntity> {
   public S478System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC223, GameMatcher.EcsSchmidC325, GameMatcher.EcsSchmidC416));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S479System : ReactiveSystem<GameEntity> {
   public S479System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC251, GameMatcher.EcsSchmidC496, GameMatcher.EcsSchmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S480System : ReactiveSystem<GameEntity> {
   public S480System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC240, GameMatcher.EcsSchmidC178, GameMatcher.EcsSchmidC209));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S481System : ReactiveSystem<GameEntity> {
   public S481System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC170, GameMatcher.EcsSchmidC164, GameMatcher.EcsSchmidC343));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S482System : ReactiveSystem<GameEntity> {
   public S482System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC53, GameMatcher.EcsSchmidC439, GameMatcher.EcsSchmidC82));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S483System : ReactiveSystem<GameEntity> {
   public S483System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC168, GameMatcher.EcsSchmidC210, GameMatcher.EcsSchmidC355));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S484System : ReactiveSystem<GameEntity> {
   public S484System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC253, GameMatcher.EcsSchmidC147, GameMatcher.EcsSchmidC339));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S485System : ReactiveSystem<GameEntity> {
   public S485System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC483, GameMatcher.EcsSchmidC205, GameMatcher.EcsSchmidC416));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S486System : ReactiveSystem<GameEntity> {
   public S486System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC389, GameMatcher.EcsSchmidC281, GameMatcher.EcsSchmidC18));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S487System : ReactiveSystem<GameEntity> {
   public S487System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC45, GameMatcher.EcsSchmidC161));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S488System : ReactiveSystem<GameEntity> {
   public S488System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC129, GameMatcher.EcsSchmidC165, GameMatcher.EcsSchmidC59));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S489System : ReactiveSystem<GameEntity> {
   public S489System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC496, GameMatcher.EcsSchmidC395, GameMatcher.EcsSchmidC206));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S490System : ReactiveSystem<GameEntity> {
   public S490System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC263, GameMatcher.EcsSchmidC422));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S491System : ReactiveSystem<GameEntity> {
   public S491System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC0, GameMatcher.EcsSchmidC336, GameMatcher.EcsSchmidC445));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S492System : ReactiveSystem<GameEntity> {
   public S492System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC277, GameMatcher.EcsSchmidC236, GameMatcher.EcsSchmidC211));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S493System : ReactiveSystem<GameEntity> {
   public S493System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC27, GameMatcher.EcsSchmidC96, GameMatcher.EcsSchmidC265));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S494System : ReactiveSystem<GameEntity> {
   public S494System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC185, GameMatcher.EcsSchmidC318, GameMatcher.EcsSchmidC387));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S495System : ReactiveSystem<GameEntity> {
   public S495System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC255, GameMatcher.EcsSchmidC320, GameMatcher.EcsSchmidC226));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S496System : ReactiveSystem<GameEntity> {
   public S496System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC389, GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC104));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S497System : ReactiveSystem<GameEntity> {
   public S497System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC136, GameMatcher.EcsSchmidC281, GameMatcher.EcsSchmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S498System : ReactiveSystem<GameEntity> {
   public S498System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC474, GameMatcher.EcsSchmidC147, GameMatcher.EcsSchmidC224));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S499System : ReactiveSystem<GameEntity> {
   public S499System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC357, GameMatcher.EcsSchmidC248));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S500System : ReactiveSystem<GameEntity> {
   public S500System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC14, GameMatcher.EcsSchmidC498));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S501System : ReactiveSystem<GameEntity> {
   public S501System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC322, GameMatcher.EcsSchmidC311, GameMatcher.EcsSchmidC409));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S502System : ReactiveSystem<GameEntity> {
   public S502System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC122, GameMatcher.EcsSchmidC363, GameMatcher.EcsSchmidC81));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S503System : ReactiveSystem<GameEntity> {
   public S503System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC159, GameMatcher.EcsSchmidC282, GameMatcher.EcsSchmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S504System : ReactiveSystem<GameEntity> {
   public S504System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC282, GameMatcher.EcsSchmidC208, GameMatcher.EcsSchmidC47));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S505System : ReactiveSystem<GameEntity> {
   public S505System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC115, GameMatcher.EcsSchmidC430, GameMatcher.EcsSchmidC467));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S506System : ReactiveSystem<GameEntity> {
   public S506System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC236, GameMatcher.EcsSchmidC484));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S507System : ReactiveSystem<GameEntity> {
   public S507System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC60, GameMatcher.EcsSchmidC331, GameMatcher.EcsSchmidC426));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S508System : ReactiveSystem<GameEntity> {
   public S508System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC78, GameMatcher.EcsSchmidC255, GameMatcher.EcsSchmidC477));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S509System : ReactiveSystem<GameEntity> {
   public S509System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC366, GameMatcher.EcsSchmidC149, GameMatcher.EcsSchmidC260));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S510System : ReactiveSystem<GameEntity> {
   public S510System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC361, GameMatcher.EcsSchmidC139, GameMatcher.EcsSchmidC212));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S511System : ReactiveSystem<GameEntity> {
   public S511System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC427, GameMatcher.EcsSchmidC247, GameMatcher.EcsSchmidC241));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S512System : ReactiveSystem<GameEntity> {
   public S512System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC124, GameMatcher.EcsSchmidC233, GameMatcher.EcsSchmidC282));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S513System : ReactiveSystem<GameEntity> {
   public S513System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC74, GameMatcher.EcsSchmidC196, GameMatcher.EcsSchmidC97));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S514System : ReactiveSystem<GameEntity> {
   public S514System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC471, GameMatcher.EcsSchmidC306, GameMatcher.EcsSchmidC260));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S515System : ReactiveSystem<GameEntity> {
   public S515System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC382, GameMatcher.EcsSchmidC450, GameMatcher.EcsSchmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S516System : ReactiveSystem<GameEntity> {
   public S516System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC141));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S517System : ReactiveSystem<GameEntity> {
   public S517System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC395, GameMatcher.EcsSchmidC404, GameMatcher.EcsSchmidC437));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S518System : ReactiveSystem<GameEntity> {
   public S518System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC212, GameMatcher.EcsSchmidC174, GameMatcher.EcsSchmidC478));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S519System : ReactiveSystem<GameEntity> {
   public S519System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC403, GameMatcher.EcsSchmidC259, GameMatcher.EcsSchmidC136));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S520System : ReactiveSystem<GameEntity> {
   public S520System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC420, GameMatcher.EcsSchmidC1, GameMatcher.EcsSchmidC144));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S521System : ReactiveSystem<GameEntity> {
   public S521System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC371, GameMatcher.EcsSchmidC152, GameMatcher.EcsSchmidC428));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S522System : ReactiveSystem<GameEntity> {
   public S522System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC300, GameMatcher.EcsSchmidC296, GameMatcher.EcsSchmidC337));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S523System : ReactiveSystem<GameEntity> {
   public S523System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC250, GameMatcher.EcsSchmidC443, GameMatcher.EcsSchmidC76));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S524System : ReactiveSystem<GameEntity> {
   public S524System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC228, GameMatcher.EcsSchmidC275, GameMatcher.EcsSchmidC247));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S525System : ReactiveSystem<GameEntity> {
   public S525System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC176, GameMatcher.EcsSchmidC170, GameMatcher.EcsSchmidC282));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S526System : ReactiveSystem<GameEntity> {
   public S526System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC390, GameMatcher.EcsSchmidC278, GameMatcher.EcsSchmidC193));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S527System : ReactiveSystem<GameEntity> {
   public S527System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC233, GameMatcher.EcsSchmidC477, GameMatcher.EcsSchmidC164));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S528System : ReactiveSystem<GameEntity> {
   public S528System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC445, GameMatcher.EcsSchmidC96, GameMatcher.EcsSchmidC357));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S529System : ReactiveSystem<GameEntity> {
   public S529System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC122, GameMatcher.EcsSchmidC292, GameMatcher.EcsSchmidC196));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S530System : ReactiveSystem<GameEntity> {
   public S530System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC119, GameMatcher.EcsSchmidC438, GameMatcher.EcsSchmidC397));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S531System : ReactiveSystem<GameEntity> {
   public S531System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC210, GameMatcher.EcsSchmidC22, GameMatcher.EcsSchmidC162));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S532System : ReactiveSystem<GameEntity> {
   public S532System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC381, GameMatcher.EcsSchmidC242, GameMatcher.EcsSchmidC361));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S533System : ReactiveSystem<GameEntity> {
   public S533System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC467, GameMatcher.EcsSchmidC415, GameMatcher.EcsSchmidC195));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S534System : ReactiveSystem<GameEntity> {
   public S534System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC197, GameMatcher.EcsSchmidC339, GameMatcher.EcsSchmidC405));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S535System : ReactiveSystem<GameEntity> {
   public S535System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC420, GameMatcher.EcsSchmidC333, GameMatcher.EcsSchmidC77));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S536System : ReactiveSystem<GameEntity> {
   public S536System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC253, GameMatcher.EcsSchmidC493, GameMatcher.EcsSchmidC18));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S537System : ReactiveSystem<GameEntity> {
   public S537System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC257, GameMatcher.EcsSchmidC494));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S538System : ReactiveSystem<GameEntity> {
   public S538System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC302, GameMatcher.EcsSchmidC169, GameMatcher.EcsSchmidC445));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S539System : ReactiveSystem<GameEntity> {
   public S539System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC447, GameMatcher.EcsSchmidC432));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S540System : ReactiveSystem<GameEntity> {
   public S540System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC225, GameMatcher.EcsSchmidC51, GameMatcher.EcsSchmidC269));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S541System : ReactiveSystem<GameEntity> {
   public S541System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC466, GameMatcher.EcsSchmidC233, GameMatcher.EcsSchmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S542System : ReactiveSystem<GameEntity> {
   public S542System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC369, GameMatcher.EcsSchmidC73, GameMatcher.EcsSchmidC209));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S543System : ReactiveSystem<GameEntity> {
   public S543System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC445, GameMatcher.EcsSchmidC335, GameMatcher.EcsSchmidC496));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S544System : ReactiveSystem<GameEntity> {
   public S544System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC240));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S545System : ReactiveSystem<GameEntity> {
   public S545System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC400, GameMatcher.EcsSchmidC496, GameMatcher.EcsSchmidC135));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S546System : ReactiveSystem<GameEntity> {
   public S546System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC173, GameMatcher.EcsSchmidC319, GameMatcher.EcsSchmidC354));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S547System : ReactiveSystem<GameEntity> {
   public S547System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC203, GameMatcher.EcsSchmidC332, GameMatcher.EcsSchmidC41));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S548System : ReactiveSystem<GameEntity> {
   public S548System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC436, GameMatcher.EcsSchmidC168, GameMatcher.EcsSchmidC345));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S549System : ReactiveSystem<GameEntity> {
   public S549System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC439, GameMatcher.EcsSchmidC273, GameMatcher.EcsSchmidC194));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S550System : ReactiveSystem<GameEntity> {
   public S550System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC488, GameMatcher.EcsSchmidC162, GameMatcher.EcsSchmidC320));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S551System : ReactiveSystem<GameEntity> {
   public S551System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC367, GameMatcher.EcsSchmidC454, GameMatcher.EcsSchmidC388));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S552System : ReactiveSystem<GameEntity> {
   public S552System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC249, GameMatcher.EcsSchmidC446, GameMatcher.EcsSchmidC277));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S553System : ReactiveSystem<GameEntity> {
   public S553System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC18, GameMatcher.EcsSchmidC316, GameMatcher.EcsSchmidC35));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S554System : ReactiveSystem<GameEntity> {
   public S554System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC120, GameMatcher.EcsSchmidC323, GameMatcher.EcsSchmidC350));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S555System : ReactiveSystem<GameEntity> {
   public S555System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC471, GameMatcher.EcsSchmidC147, GameMatcher.EcsSchmidC116));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S556System : ReactiveSystem<GameEntity> {
   public S556System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC382, GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC222));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S557System : ReactiveSystem<GameEntity> {
   public S557System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC389, GameMatcher.EcsSchmidC324));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S558System : ReactiveSystem<GameEntity> {
   public S558System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC360, GameMatcher.EcsSchmidC446, GameMatcher.EcsSchmidC51));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S559System : ReactiveSystem<GameEntity> {
   public S559System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC227, GameMatcher.EcsSchmidC85, GameMatcher.EcsSchmidC355));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S560System : ReactiveSystem<GameEntity> {
   public S560System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC153, GameMatcher.EcsSchmidC462, GameMatcher.EcsSchmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S561System : ReactiveSystem<GameEntity> {
   public S561System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC23, GameMatcher.EcsSchmidC166, GameMatcher.EcsSchmidC407));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S562System : ReactiveSystem<GameEntity> {
   public S562System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC28, GameMatcher.EcsSchmidC150, GameMatcher.EcsSchmidC183));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S563System : ReactiveSystem<GameEntity> {
   public S563System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC191, GameMatcher.EcsSchmidC220, GameMatcher.EcsSchmidC74));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S564System : ReactiveSystem<GameEntity> {
   public S564System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC125, GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC210));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S565System : ReactiveSystem<GameEntity> {
   public S565System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC289, GameMatcher.EcsSchmidC349, GameMatcher.EcsSchmidC405));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S566System : ReactiveSystem<GameEntity> {
   public S566System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC92, GameMatcher.EcsSchmidC87, GameMatcher.EcsSchmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S567System : ReactiveSystem<GameEntity> {
   public S567System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC40, GameMatcher.EcsSchmidC312, GameMatcher.EcsSchmidC445));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S568System : ReactiveSystem<GameEntity> {
   public S568System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC195, GameMatcher.EcsSchmidC317, GameMatcher.EcsSchmidC349));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S569System : ReactiveSystem<GameEntity> {
   public S569System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC123, GameMatcher.EcsSchmidC254, GameMatcher.EcsSchmidC467));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S570System : ReactiveSystem<GameEntity> {
   public S570System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC298, GameMatcher.EcsSchmidC73, GameMatcher.EcsSchmidC118));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S571System : ReactiveSystem<GameEntity> {
   public S571System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC236, GameMatcher.EcsSchmidC326, GameMatcher.EcsSchmidC130));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S572System : ReactiveSystem<GameEntity> {
   public S572System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC235, GameMatcher.EcsSchmidC130, GameMatcher.EcsSchmidC341));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S573System : ReactiveSystem<GameEntity> {
   public S573System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC4, GameMatcher.EcsSchmidC460, GameMatcher.EcsSchmidC411));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S574System : ReactiveSystem<GameEntity> {
   public S574System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC238, GameMatcher.EcsSchmidC461, GameMatcher.EcsSchmidC147));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S575System : ReactiveSystem<GameEntity> {
   public S575System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC346, GameMatcher.EcsSchmidC279, GameMatcher.EcsSchmidC80));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S576System : ReactiveSystem<GameEntity> {
   public S576System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC37, GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC483));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S577System : ReactiveSystem<GameEntity> {
   public S577System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC176, GameMatcher.EcsSchmidC300, GameMatcher.EcsSchmidC153));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S578System : ReactiveSystem<GameEntity> {
   public S578System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC327, GameMatcher.EcsSchmidC492, GameMatcher.EcsSchmidC217));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S579System : ReactiveSystem<GameEntity> {
   public S579System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC353, GameMatcher.EcsSchmidC128, GameMatcher.EcsSchmidC233));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S580System : ReactiveSystem<GameEntity> {
   public S580System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC432, GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC101));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S581System : ReactiveSystem<GameEntity> {
   public S581System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC196, GameMatcher.EcsSchmidC436, GameMatcher.EcsSchmidC247));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S582System : ReactiveSystem<GameEntity> {
   public S582System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC54, GameMatcher.EcsSchmidC121, GameMatcher.EcsSchmidC195));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S583System : ReactiveSystem<GameEntity> {
   public S583System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC292, GameMatcher.EcsSchmidC183, GameMatcher.EcsSchmidC294));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S584System : ReactiveSystem<GameEntity> {
   public S584System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC151, GameMatcher.EcsSchmidC358, GameMatcher.EcsSchmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S585System : ReactiveSystem<GameEntity> {
   public S585System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC424, GameMatcher.EcsSchmidC337, GameMatcher.EcsSchmidC202));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S586System : ReactiveSystem<GameEntity> {
   public S586System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC140, GameMatcher.EcsSchmidC4, GameMatcher.EcsSchmidC289));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S587System : ReactiveSystem<GameEntity> {
   public S587System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC442, GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC398));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S588System : ReactiveSystem<GameEntity> {
   public S588System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC381, GameMatcher.EcsSchmidC498, GameMatcher.EcsSchmidC25));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S589System : ReactiveSystem<GameEntity> {
   public S589System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC466, GameMatcher.EcsSchmidC310, GameMatcher.EcsSchmidC381));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S590System : ReactiveSystem<GameEntity> {
   public S590System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC254, GameMatcher.EcsSchmidC426, GameMatcher.EcsSchmidC462));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S591System : ReactiveSystem<GameEntity> {
   public S591System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC462, GameMatcher.EcsSchmidC146, GameMatcher.EcsSchmidC397));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S592System : ReactiveSystem<GameEntity> {
   public S592System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC409, GameMatcher.EcsSchmidC117, GameMatcher.EcsSchmidC310));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S593System : ReactiveSystem<GameEntity> {
   public S593System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC410, GameMatcher.EcsSchmidC180, GameMatcher.EcsSchmidC112));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S594System : ReactiveSystem<GameEntity> {
   public S594System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC325, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC317));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S595System : ReactiveSystem<GameEntity> {
   public S595System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC128, GameMatcher.EcsSchmidC347, GameMatcher.EcsSchmidC386));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S596System : ReactiveSystem<GameEntity> {
   public S596System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC369, GameMatcher.EcsSchmidC392, GameMatcher.EcsSchmidC337));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S597System : ReactiveSystem<GameEntity> {
   public S597System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC348, GameMatcher.EcsSchmidC429, GameMatcher.EcsSchmidC70));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S598System : ReactiveSystem<GameEntity> {
   public S598System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC321, GameMatcher.EcsSchmidC49, GameMatcher.EcsSchmidC462));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S599System : ReactiveSystem<GameEntity> {
   public S599System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC321, GameMatcher.EcsSchmidC330, GameMatcher.EcsSchmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S600System : ReactiveSystem<GameEntity> {
   public S600System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC158, GameMatcher.EcsSchmidC403, GameMatcher.EcsSchmidC225));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S601System : ReactiveSystem<GameEntity> {
   public S601System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC17, GameMatcher.EcsSchmidC296, GameMatcher.EcsSchmidC186));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S602System : ReactiveSystem<GameEntity> {
   public S602System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC374, GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S603System : ReactiveSystem<GameEntity> {
   public S603System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC465, GameMatcher.EcsSchmidC151, GameMatcher.EcsSchmidC167));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S604System : ReactiveSystem<GameEntity> {
   public S604System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC382, GameMatcher.EcsSchmidC212, GameMatcher.EcsSchmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S605System : ReactiveSystem<GameEntity> {
   public S605System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC102, GameMatcher.EcsSchmidC67, GameMatcher.EcsSchmidC402));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S606System : ReactiveSystem<GameEntity> {
   public S606System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC448, GameMatcher.EcsSchmidC497));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S607System : ReactiveSystem<GameEntity> {
   public S607System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC187, GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC256));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S608System : ReactiveSystem<GameEntity> {
   public S608System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC467, GameMatcher.EcsSchmidC139, GameMatcher.EcsSchmidC425));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S609System : ReactiveSystem<GameEntity> {
   public S609System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC84, GameMatcher.EcsSchmidC131, GameMatcher.EcsSchmidC467));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S610System : ReactiveSystem<GameEntity> {
   public S610System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC422, GameMatcher.EcsSchmidC483, GameMatcher.EcsSchmidC246));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S611System : ReactiveSystem<GameEntity> {
   public S611System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC495, GameMatcher.EcsSchmidC412, GameMatcher.EcsSchmidC151));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S612System : ReactiveSystem<GameEntity> {
   public S612System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC382, GameMatcher.EcsSchmidC445, GameMatcher.EcsSchmidC173));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S613System : ReactiveSystem<GameEntity> {
   public S613System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC411, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC239));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S614System : ReactiveSystem<GameEntity> {
   public S614System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC493, GameMatcher.EcsSchmidC38, GameMatcher.EcsSchmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S615System : ReactiveSystem<GameEntity> {
   public S615System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC386, GameMatcher.EcsSchmidC494, GameMatcher.EcsSchmidC115));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S616System : ReactiveSystem<GameEntity> {
   public S616System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC440, GameMatcher.EcsSchmidC346, GameMatcher.EcsSchmidC370));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S617System : ReactiveSystem<GameEntity> {
   public S617System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC345, GameMatcher.EcsSchmidC203, GameMatcher.EcsSchmidC495));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S618System : ReactiveSystem<GameEntity> {
   public S618System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC433, GameMatcher.EcsSchmidC411, GameMatcher.EcsSchmidC285));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S619System : ReactiveSystem<GameEntity> {
   public S619System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC187, GameMatcher.EcsSchmidC46, GameMatcher.EcsSchmidC404));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S620System : ReactiveSystem<GameEntity> {
   public S620System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC202, GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC135));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S621System : ReactiveSystem<GameEntity> {
   public S621System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC274, GameMatcher.EcsSchmidC63, GameMatcher.EcsSchmidC232));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S622System : ReactiveSystem<GameEntity> {
   public S622System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC188, GameMatcher.EcsSchmidC344, GameMatcher.EcsSchmidC383));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S623System : ReactiveSystem<GameEntity> {
   public S623System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC344, GameMatcher.EcsSchmidC134, GameMatcher.EcsSchmidC299));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S624System : ReactiveSystem<GameEntity> {
   public S624System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC195, GameMatcher.EcsSchmidC421, GameMatcher.EcsSchmidC326));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S625System : ReactiveSystem<GameEntity> {
   public S625System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC481, GameMatcher.EcsSchmidC190, GameMatcher.EcsSchmidC55));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S626System : ReactiveSystem<GameEntity> {
   public S626System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC345, GameMatcher.EcsSchmidC119, GameMatcher.EcsSchmidC241));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S627System : ReactiveSystem<GameEntity> {
   public S627System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC12, GameMatcher.EcsSchmidC317, GameMatcher.EcsSchmidC452));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S628System : ReactiveSystem<GameEntity> {
   public S628System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC482, GameMatcher.EcsSchmidC287, GameMatcher.EcsSchmidC167));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S629System : ReactiveSystem<GameEntity> {
   public S629System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC468, GameMatcher.EcsSchmidC312, GameMatcher.EcsSchmidC113));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S630System : ReactiveSystem<GameEntity> {
   public S630System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC331, GameMatcher.EcsSchmidC32, GameMatcher.EcsSchmidC325));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S631System : ReactiveSystem<GameEntity> {
   public S631System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC421, GameMatcher.EcsSchmidC237, GameMatcher.EcsSchmidC465));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S632System : ReactiveSystem<GameEntity> {
   public S632System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC358, GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC332));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S633System : ReactiveSystem<GameEntity> {
   public S633System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC209, GameMatcher.EcsSchmidC59, GameMatcher.EcsSchmidC71));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S634System : ReactiveSystem<GameEntity> {
   public S634System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC23, GameMatcher.EcsSchmidC484, GameMatcher.EcsSchmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S635System : ReactiveSystem<GameEntity> {
   public S635System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC155, GameMatcher.EcsSchmidC252, GameMatcher.EcsSchmidC59));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S636System : ReactiveSystem<GameEntity> {
   public S636System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC49, GameMatcher.EcsSchmidC120, GameMatcher.EcsSchmidC454));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S637System : ReactiveSystem<GameEntity> {
   public S637System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC275, GameMatcher.EcsSchmidC69, GameMatcher.EcsSchmidC198));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S638System : ReactiveSystem<GameEntity> {
   public S638System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC189, GameMatcher.EcsSchmidC343));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S639System : ReactiveSystem<GameEntity> {
   public S639System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC486, GameMatcher.EcsSchmidC380, GameMatcher.EcsSchmidC356));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S640System : ReactiveSystem<GameEntity> {
   public S640System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC484, GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC214));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S641System : ReactiveSystem<GameEntity> {
   public S641System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC300, GameMatcher.EcsSchmidC380, GameMatcher.EcsSchmidC372));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S642System : ReactiveSystem<GameEntity> {
   public S642System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC453, GameMatcher.EcsSchmidC212));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S643System : ReactiveSystem<GameEntity> {
   public S643System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC335, GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC426));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S644System : ReactiveSystem<GameEntity> {
   public S644System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC250, GameMatcher.EcsSchmidC315, GameMatcher.EcsSchmidC208));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S645System : ReactiveSystem<GameEntity> {
   public S645System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC480, GameMatcher.EcsSchmidC487, GameMatcher.EcsSchmidC143));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S646System : ReactiveSystem<GameEntity> {
   public S646System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC16, GameMatcher.EcsSchmidC353, GameMatcher.EcsSchmidC189));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S647System : ReactiveSystem<GameEntity> {
   public S647System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC111, GameMatcher.EcsSchmidC227, GameMatcher.EcsSchmidC486));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S648System : ReactiveSystem<GameEntity> {
   public S648System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC120, GameMatcher.EcsSchmidC437, GameMatcher.EcsSchmidC185));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S649System : ReactiveSystem<GameEntity> {
   public S649System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC188));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S650System : ReactiveSystem<GameEntity> {
   public S650System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC278, GameMatcher.EcsSchmidC461, GameMatcher.EcsSchmidC330));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S651System : ReactiveSystem<GameEntity> {
   public S651System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC183, GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC203));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S652System : ReactiveSystem<GameEntity> {
   public S652System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC141, GameMatcher.EcsSchmidC97, GameMatcher.EcsSchmidC495));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S653System : ReactiveSystem<GameEntity> {
   public S653System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC485, GameMatcher.EcsSchmidC434));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S654System : ReactiveSystem<GameEntity> {
   public S654System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC421, GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S655System : ReactiveSystem<GameEntity> {
   public S655System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC339, GameMatcher.EcsSchmidC108, GameMatcher.EcsSchmidC328));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S656System : ReactiveSystem<GameEntity> {
   public S656System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC327, GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC497));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S657System : ReactiveSystem<GameEntity> {
   public S657System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC10, GameMatcher.EcsSchmidC25, GameMatcher.EcsSchmidC402));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S658System : ReactiveSystem<GameEntity> {
   public S658System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC170, GameMatcher.EcsSchmidC124, GameMatcher.EcsSchmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S659System : ReactiveSystem<GameEntity> {
   public S659System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC402, GameMatcher.EcsSchmidC289, GameMatcher.EcsSchmidC105));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S660System : ReactiveSystem<GameEntity> {
   public S660System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC35, GameMatcher.EcsSchmidC424, GameMatcher.EcsSchmidC391));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S661System : ReactiveSystem<GameEntity> {
   public S661System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC283, GameMatcher.EcsSchmidC106, GameMatcher.EcsSchmidC300));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S662System : ReactiveSystem<GameEntity> {
   public S662System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC110, GameMatcher.EcsSchmidC416, GameMatcher.EcsSchmidC445));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S663System : ReactiveSystem<GameEntity> {
   public S663System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC119, GameMatcher.EcsSchmidC168, GameMatcher.EcsSchmidC396));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S664System : ReactiveSystem<GameEntity> {
   public S664System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC403, GameMatcher.EcsSchmidC461));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S665System : ReactiveSystem<GameEntity> {
   public S665System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC1, GameMatcher.EcsSchmidC141));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S666System : ReactiveSystem<GameEntity> {
   public S666System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC439, GameMatcher.EcsSchmidC74, GameMatcher.EcsSchmidC66));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S667System : ReactiveSystem<GameEntity> {
   public S667System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC276, GameMatcher.EcsSchmidC128, GameMatcher.EcsSchmidC408));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S668System : ReactiveSystem<GameEntity> {
   public S668System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC89, GameMatcher.EcsSchmidC56, GameMatcher.EcsSchmidC338));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S669System : ReactiveSystem<GameEntity> {
   public S669System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC443, GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S670System : ReactiveSystem<GameEntity> {
   public S670System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC7, GameMatcher.EcsSchmidC183, GameMatcher.EcsSchmidC404));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S671System : ReactiveSystem<GameEntity> {
   public S671System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC403, GameMatcher.EcsSchmidC121, GameMatcher.EcsSchmidC301));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S672System : ReactiveSystem<GameEntity> {
   public S672System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC165, GameMatcher.EcsSchmidC8, GameMatcher.EcsSchmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S673System : ReactiveSystem<GameEntity> {
   public S673System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC135, GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S674System : ReactiveSystem<GameEntity> {
   public S674System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC379, GameMatcher.EcsSchmidC215, GameMatcher.EcsSchmidC269));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S675System : ReactiveSystem<GameEntity> {
   public S675System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC381, GameMatcher.EcsSchmidC32));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S676System : ReactiveSystem<GameEntity> {
   public S676System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC243, GameMatcher.EcsSchmidC229, GameMatcher.EcsSchmidC398));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S677System : ReactiveSystem<GameEntity> {
   public S677System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC185, GameMatcher.EcsSchmidC262, GameMatcher.EcsSchmidC303));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S678System : ReactiveSystem<GameEntity> {
   public S678System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC231, GameMatcher.EcsSchmidC257));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S679System : ReactiveSystem<GameEntity> {
   public S679System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC113, GameMatcher.EcsSchmidC484, GameMatcher.EcsSchmidC314));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S680System : ReactiveSystem<GameEntity> {
   public S680System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC22, GameMatcher.EcsSchmidC372, GameMatcher.EcsSchmidC401));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S681System : ReactiveSystem<GameEntity> {
   public S681System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC465, GameMatcher.EcsSchmidC443, GameMatcher.EcsSchmidC337));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S682System : ReactiveSystem<GameEntity> {
   public S682System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC266, GameMatcher.EcsSchmidC154, GameMatcher.EcsSchmidC234));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S683System : ReactiveSystem<GameEntity> {
   public S683System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC329, GameMatcher.EcsSchmidC493, GameMatcher.EcsSchmidC15));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S684System : ReactiveSystem<GameEntity> {
   public S684System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC31, GameMatcher.EcsSchmidC245, GameMatcher.EcsSchmidC433));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S685System : ReactiveSystem<GameEntity> {
   public S685System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC205, GameMatcher.EcsSchmidC218, GameMatcher.EcsSchmidC351));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S686System : ReactiveSystem<GameEntity> {
   public S686System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC55, GameMatcher.EcsSchmidC251, GameMatcher.EcsSchmidC364));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S687System : ReactiveSystem<GameEntity> {
   public S687System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC465, GameMatcher.EcsSchmidC227, GameMatcher.EcsSchmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S688System : ReactiveSystem<GameEntity> {
   public S688System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC460, GameMatcher.EcsSchmidC41, GameMatcher.EcsSchmidC164));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S689System : ReactiveSystem<GameEntity> {
   public S689System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC311, GameMatcher.EcsSchmidC75, GameMatcher.EcsSchmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S690System : ReactiveSystem<GameEntity> {
   public S690System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC64, GameMatcher.EcsSchmidC140, GameMatcher.EcsSchmidC319));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S691System : ReactiveSystem<GameEntity> {
   public S691System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC324, GameMatcher.EcsSchmidC299, GameMatcher.EcsSchmidC280));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S692System : ReactiveSystem<GameEntity> {
   public S692System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC364, GameMatcher.EcsSchmidC166, GameMatcher.EcsSchmidC195));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S693System : ReactiveSystem<GameEntity> {
   public S693System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC150));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S694System : ReactiveSystem<GameEntity> {
   public S694System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC258, GameMatcher.EcsSchmidC309));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S695System : ReactiveSystem<GameEntity> {
   public S695System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC220, GameMatcher.EcsSchmidC50, GameMatcher.EcsSchmidC406));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S696System : ReactiveSystem<GameEntity> {
   public S696System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC359, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC436));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S697System : ReactiveSystem<GameEntity> {
   public S697System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC335, GameMatcher.EcsSchmidC333, GameMatcher.EcsSchmidC449));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S698System : ReactiveSystem<GameEntity> {
   public S698System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC393, GameMatcher.EcsSchmidC282, GameMatcher.EcsSchmidC369));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S699System : ReactiveSystem<GameEntity> {
   public S699System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC443, GameMatcher.EcsSchmidC110, GameMatcher.EcsSchmidC220));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S700System : ReactiveSystem<GameEntity> {
   public S700System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC231, GameMatcher.EcsSchmidC454, GameMatcher.EcsSchmidC116));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S701System : ReactiveSystem<GameEntity> {
   public S701System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC211, GameMatcher.EcsSchmidC173, GameMatcher.EcsSchmidC423));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S702System : ReactiveSystem<GameEntity> {
   public S702System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC232, GameMatcher.EcsSchmidC204, GameMatcher.EcsSchmidC212));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S703System : ReactiveSystem<GameEntity> {
   public S703System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC373, GameMatcher.EcsSchmidC48, GameMatcher.EcsSchmidC160));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S704System : ReactiveSystem<GameEntity> {
   public S704System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC218, GameMatcher.EcsSchmidC160, GameMatcher.EcsSchmidC340));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S705System : ReactiveSystem<GameEntity> {
   public S705System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC130, GameMatcher.EcsSchmidC191, GameMatcher.EcsSchmidC488));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S706System : ReactiveSystem<GameEntity> {
   public S706System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC78, GameMatcher.EcsSchmidC351, GameMatcher.EcsSchmidC472));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S707System : ReactiveSystem<GameEntity> {
   public S707System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC242, GameMatcher.EcsSchmidC34, GameMatcher.EcsSchmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S708System : ReactiveSystem<GameEntity> {
   public S708System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC425, GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC47));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S709System : ReactiveSystem<GameEntity> {
   public S709System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC221, GameMatcher.EcsSchmidC49, GameMatcher.EcsSchmidC381));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S710System : ReactiveSystem<GameEntity> {
   public S710System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC378, GameMatcher.EcsSchmidC190, GameMatcher.EcsSchmidC415));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S711System : ReactiveSystem<GameEntity> {
   public S711System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC66, GameMatcher.EcsSchmidC284, GameMatcher.EcsSchmidC30));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S712System : ReactiveSystem<GameEntity> {
   public S712System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC300, GameMatcher.EcsSchmidC489, GameMatcher.EcsSchmidC287));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S713System : ReactiveSystem<GameEntity> {
   public S713System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC287, GameMatcher.EcsSchmidC168, GameMatcher.EcsSchmidC343));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S714System : ReactiveSystem<GameEntity> {
   public S714System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC62, GameMatcher.EcsSchmidC210, GameMatcher.EcsSchmidC181));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S715System : ReactiveSystem<GameEntity> {
   public S715System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC447, GameMatcher.EcsSchmidC340, GameMatcher.EcsSchmidC481));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S716System : ReactiveSystem<GameEntity> {
   public S716System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC384, GameMatcher.EcsSchmidC216, GameMatcher.EcsSchmidC444));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S717System : ReactiveSystem<GameEntity> {
   public S717System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC468, GameMatcher.EcsSchmidC369, GameMatcher.EcsSchmidC26));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S718System : ReactiveSystem<GameEntity> {
   public S718System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC495, GameMatcher.EcsSchmidC147, GameMatcher.EcsSchmidC307));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S719System : ReactiveSystem<GameEntity> {
   public S719System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC159, GameMatcher.EcsSchmidC180, GameMatcher.EcsSchmidC53));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S720System : ReactiveSystem<GameEntity> {
   public S720System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC295, GameMatcher.EcsSchmidC259, GameMatcher.EcsSchmidC108));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S721System : ReactiveSystem<GameEntity> {
   public S721System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC336, GameMatcher.EcsSchmidC246));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S722System : ReactiveSystem<GameEntity> {
   public S722System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC114, GameMatcher.EcsSchmidC433, GameMatcher.EcsSchmidC55));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S723System : ReactiveSystem<GameEntity> {
   public S723System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC179, GameMatcher.EcsSchmidC432, GameMatcher.EcsSchmidC284));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S724System : ReactiveSystem<GameEntity> {
   public S724System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC188, GameMatcher.EcsSchmidC58, GameMatcher.EcsSchmidC390));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S725System : ReactiveSystem<GameEntity> {
   public S725System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC142, GameMatcher.EcsSchmidC293, GameMatcher.EcsSchmidC115));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S726System : ReactiveSystem<GameEntity> {
   public S726System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC413, GameMatcher.EcsSchmidC219, GameMatcher.EcsSchmidC432));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S727System : ReactiveSystem<GameEntity> {
   public S727System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC287, GameMatcher.EcsSchmidC498, GameMatcher.EcsSchmidC392));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S728System : ReactiveSystem<GameEntity> {
   public S728System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC419, GameMatcher.EcsSchmidC318, GameMatcher.EcsSchmidC314));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S729System : ReactiveSystem<GameEntity> {
   public S729System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC345, GameMatcher.EcsSchmidC329, GameMatcher.EcsSchmidC285));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S730System : ReactiveSystem<GameEntity> {
   public S730System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC13, GameMatcher.EcsSchmidC311, GameMatcher.EcsSchmidC475));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S731System : ReactiveSystem<GameEntity> {
   public S731System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC336, GameMatcher.EcsSchmidC424, GameMatcher.EcsSchmidC355));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S732System : ReactiveSystem<GameEntity> {
   public S732System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC136, GameMatcher.EcsSchmidC14, GameMatcher.EcsSchmidC92));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S733System : ReactiveSystem<GameEntity> {
   public S733System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC139, GameMatcher.EcsSchmidC359, GameMatcher.EcsSchmidC390));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S734System : ReactiveSystem<GameEntity> {
   public S734System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC158, GameMatcher.EcsSchmidC471, GameMatcher.EcsSchmidC173));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S735System : ReactiveSystem<GameEntity> {
   public S735System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC179, GameMatcher.EcsSchmidC3, GameMatcher.EcsSchmidC92));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S736System : ReactiveSystem<GameEntity> {
   public S736System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC445, GameMatcher.EcsSchmidC73, GameMatcher.EcsSchmidC289));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S737System : ReactiveSystem<GameEntity> {
   public S737System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC336, GameMatcher.EcsSchmidC205, GameMatcher.EcsSchmidC35));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S738System : ReactiveSystem<GameEntity> {
   public S738System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC72, GameMatcher.EcsSchmidC379, GameMatcher.EcsSchmidC324));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S739System : ReactiveSystem<GameEntity> {
   public S739System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC497, GameMatcher.EcsSchmidC15, GameMatcher.EcsSchmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S740System : ReactiveSystem<GameEntity> {
   public S740System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC382, GameMatcher.EcsSchmidC271, GameMatcher.EcsSchmidC110));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S741System : ReactiveSystem<GameEntity> {
   public S741System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC192, GameMatcher.EcsSchmidC214, GameMatcher.EcsSchmidC232));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S742System : ReactiveSystem<GameEntity> {
   public S742System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC174, GameMatcher.EcsSchmidC80, GameMatcher.EcsSchmidC189));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S743System : ReactiveSystem<GameEntity> {
   public S743System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC159, GameMatcher.EcsSchmidC369, GameMatcher.EcsSchmidC166));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S744System : ReactiveSystem<GameEntity> {
   public S744System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC397, GameMatcher.EcsSchmidC482, GameMatcher.EcsSchmidC290));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S745System : ReactiveSystem<GameEntity> {
   public S745System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC305, GameMatcher.EcsSchmidC43, GameMatcher.EcsSchmidC452));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S746System : ReactiveSystem<GameEntity> {
   public S746System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC26, GameMatcher.EcsSchmidC79, GameMatcher.EcsSchmidC80));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S747System : ReactiveSystem<GameEntity> {
   public S747System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC386, GameMatcher.EcsSchmidC316, GameMatcher.EcsSchmidC25));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S748System : ReactiveSystem<GameEntity> {
   public S748System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC345, GameMatcher.EcsSchmidC41, GameMatcher.EcsSchmidC139));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 
public class S749System : ReactiveSystem<GameEntity> {
   public S749System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsSchmidC226, GameMatcher.EcsSchmidC338, GameMatcher.EcsSchmidC217));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       var i = 0;
       foreach (var e in entities){ 
 i++;
 } 
}} 

 }