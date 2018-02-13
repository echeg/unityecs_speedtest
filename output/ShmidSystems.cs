namespace EcsShmid { 

using Entitas; 
using System.Collections.Generic; 
public class S0System : ReactiveSystem<GameEntity> {
   public S0System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC81, GameMatcher.EcsShmidC14, GameMatcher.EcsShmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC81(e.ecsShmidC81.field0 + 1, 0); } 
}} 
public class S1System : ReactiveSystem<GameEntity> {
   public S1System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC94, GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC94(e.ecsShmidC94.field0 + 1, 0); } 
}} 
public class S2System : ReactiveSystem<GameEntity> {
   public S2System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC17, GameMatcher.EcsShmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC28(e.ecsShmidC28.field0 + 1, 0); } 
}} 
public class S3System : ReactiveSystem<GameEntity> {
   public S3System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC86, GameMatcher.EcsShmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC13(e.ecsShmidC13.field0 + 1, 0); } 
}} 
public class S4System : ReactiveSystem<GameEntity> {
   public S4System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC69, GameMatcher.EcsShmidC11, GameMatcher.EcsShmidC75));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC69(e.ecsShmidC69.field0 + 1, 0); } 
}} 
public class S5System : ReactiveSystem<GameEntity> {
   public S5System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC4, GameMatcher.EcsShmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC54(e.ecsShmidC54.field0 + 1, 0); } 
}} 
public class S6System : ReactiveSystem<GameEntity> {
   public S6System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC11, GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC29));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC11(e.ecsShmidC11.field0 + 1, 0); } 
}} 
public class S7System : ReactiveSystem<GameEntity> {
   public S7System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC64, GameMatcher.EcsShmidC77, GameMatcher.EcsShmidC3));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC64(e.ecsShmidC64.field0 + 1, 0); } 
}} 
public class S8System : ReactiveSystem<GameEntity> {
   public S8System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC71, GameMatcher.EcsShmidC25, GameMatcher.EcsShmidC91));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC71(e.ecsShmidC71.field0 + 1, 0); } 
}} 
public class S9System : ReactiveSystem<GameEntity> {
   public S9System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC83, GameMatcher.EcsShmidC89, GameMatcher.EcsShmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC83(e.ecsShmidC83.field0 + 1, 0); } 
}} 
public class S10System : ReactiveSystem<GameEntity> {
   public S10System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC53, GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC57));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC53(e.ecsShmidC53.field0 + 1, 0); } 
}} 
public class S11System : ReactiveSystem<GameEntity> {
   public S11System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC75, GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC0));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC75(e.ecsShmidC75.field0 + 1, 0); } 
}} 
public class S12System : ReactiveSystem<GameEntity> {
   public S12System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC97, GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC97(e.ecsShmidC97.field0 + 1, 0); } 
}} 
public class S13System : ReactiveSystem<GameEntity> {
   public S13System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC43, GameMatcher.EcsShmidC35));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC54(e.ecsShmidC54.field0 + 1, 0); } 
}} 
public class S14System : ReactiveSystem<GameEntity> {
   public S14System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC19, GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC97));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC19(e.ecsShmidC19.field0 + 1, 0); } 
}} 
public class S15System : ReactiveSystem<GameEntity> {
   public S15System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC43, GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC43(e.ecsShmidC43.field0 + 1, 0); } 
}} 
public class S16System : ReactiveSystem<GameEntity> {
   public S16System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC48, GameMatcher.EcsShmidC12, GameMatcher.EcsShmidC45));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC48(e.ecsShmidC48.field0 + 1, 0); } 
}} 
public class S17System : ReactiveSystem<GameEntity> {
   public S17System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC44, GameMatcher.EcsShmidC77, GameMatcher.EcsShmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC44(e.ecsShmidC44.field0 + 1, 0); } 
}} 
public class S18System : ReactiveSystem<GameEntity> {
   public S18System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC5, GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC5(e.ecsShmidC5.field0 + 1, 0); } 
}} 
public class S19System : ReactiveSystem<GameEntity> {
   public S19System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC68, GameMatcher.EcsShmidC15, GameMatcher.EcsShmidC48));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC68(e.ecsShmidC68.field0 + 1, 0); } 
}} 
public class S20System : ReactiveSystem<GameEntity> {
   public S20System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC10, GameMatcher.EcsShmidC70, GameMatcher.EcsShmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC10(e.ecsShmidC10.field0 + 1, 0); } 
}} 
public class S21System : ReactiveSystem<GameEntity> {
   public S21System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC80, GameMatcher.EcsShmidC79, GameMatcher.EcsShmidC46));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC80(e.ecsShmidC80.field0 + 1, 0); } 
}} 
public class S22System : ReactiveSystem<GameEntity> {
   public S22System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC73, GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC90));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC73(e.ecsShmidC73.field0 + 1, 0); } 
}} 
public class S23System : ReactiveSystem<GameEntity> {
   public S23System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC5, GameMatcher.EcsShmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); } 
}} 
public class S24System : ReactiveSystem<GameEntity> {
   public S24System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC29, GameMatcher.EcsShmidC98, GameMatcher.EcsShmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC29(e.ecsShmidC29.field0 + 1, 0); } 
}} 
public class S25System : ReactiveSystem<GameEntity> {
   public S25System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC10, GameMatcher.EcsShmidC29, GameMatcher.EcsShmidC12));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC10(e.ecsShmidC10.field0 + 1, 0); } 
}} 
public class S26System : ReactiveSystem<GameEntity> {
   public S26System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC48, GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC48(e.ecsShmidC48.field0 + 1, 0); } 
}} 
public class S27System : ReactiveSystem<GameEntity> {
   public S27System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC81, GameMatcher.EcsShmidC46, GameMatcher.EcsShmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC81(e.ecsShmidC81.field0 + 1, 0); } 
}} 
public class S28System : ReactiveSystem<GameEntity> {
   public S28System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC47, GameMatcher.EcsShmidC45, GameMatcher.EcsShmidC26));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC47(e.ecsShmidC47.field0 + 1, 0); } 
}} 
public class S29System : ReactiveSystem<GameEntity> {
   public S29System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC34, GameMatcher.EcsShmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC85(e.ecsShmidC85.field0 + 1, 0); } 
}} 
public class S30System : ReactiveSystem<GameEntity> {
   public S30System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC87, GameMatcher.EcsShmidC82, GameMatcher.EcsShmidC9));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC87(e.ecsShmidC87.field0 + 1, 0); } 
}} 
public class S31System : ReactiveSystem<GameEntity> {
   public S31System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC77, GameMatcher.EcsShmidC81, GameMatcher.EcsShmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC77(e.ecsShmidC77.field0 + 1, 0); } 
}} 
public class S32System : ReactiveSystem<GameEntity> {
   public S32System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC68, GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC68(e.ecsShmidC68.field0 + 1, 0); } 
}} 
public class S33System : ReactiveSystem<GameEntity> {
   public S33System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC59, GameMatcher.EcsShmidC48));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC20(e.ecsShmidC20.field0 + 1, 0); } 
}} 
public class S34System : ReactiveSystem<GameEntity> {
   public S34System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC34, GameMatcher.EcsShmidC81, GameMatcher.EcsShmidC88));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC34(e.ecsShmidC34.field0 + 1, 0); } 
}} 
public class S35System : ReactiveSystem<GameEntity> {
   public S35System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC71, GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC87));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC71(e.ecsShmidC71.field0 + 1, 0); } 
}} 
public class S36System : ReactiveSystem<GameEntity> {
   public S36System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC41, GameMatcher.EcsShmidC98, GameMatcher.EcsShmidC99));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC41(e.ecsShmidC41.field0 + 1, 0); } 
}} 
public class S37System : ReactiveSystem<GameEntity> {
   public S37System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC7, GameMatcher.EcsShmidC29, GameMatcher.EcsShmidC4));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC7(e.ecsShmidC7.field0 + 1, 0); } 
}} 
public class S38System : ReactiveSystem<GameEntity> {
   public S38System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC40, GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC34));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC40(e.ecsShmidC40.field0 + 1, 0); } 
}} 
public class S39System : ReactiveSystem<GameEntity> {
   public S39System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); } 
}} 
public class S40System : ReactiveSystem<GameEntity> {
   public S40System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC91, GameMatcher.EcsShmidC40, GameMatcher.EcsShmidC27));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC91(e.ecsShmidC91.field0 + 1, 0); } 
}} 
public class S41System : ReactiveSystem<GameEntity> {
   public S41System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC83, GameMatcher.EcsShmidC63, GameMatcher.EcsShmidC50));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC83(e.ecsShmidC83.field0 + 1, 0); } 
}} 
public class S42System : ReactiveSystem<GameEntity> {
   public S42System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC82, GameMatcher.EcsShmidC58, GameMatcher.EcsShmidC18));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC82(e.ecsShmidC82.field0 + 1, 0); } 
}} 
public class S43System : ReactiveSystem<GameEntity> {
   public S43System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC17, GameMatcher.EcsShmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC33(e.ecsShmidC33.field0 + 1, 0); } 
}} 
public class S44System : ReactiveSystem<GameEntity> {
   public S44System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC95, GameMatcher.EcsShmidC71, GameMatcher.EcsShmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC95(e.ecsShmidC95.field0 + 1, 0); } 
}} 
public class S45System : ReactiveSystem<GameEntity> {
   public S45System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC95, GameMatcher.EcsShmidC74));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC33(e.ecsShmidC33.field0 + 1, 0); } 
}} 
public class S46System : ReactiveSystem<GameEntity> {
   public S46System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC74, GameMatcher.EcsShmidC51));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC54(e.ecsShmidC54.field0 + 1, 0); } 
}} 
public class S47System : ReactiveSystem<GameEntity> {
   public S47System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC46, GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC17));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC46(e.ecsShmidC46.field0 + 1, 0); } 
}} 
public class S48System : ReactiveSystem<GameEntity> {
   public S48System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC65, GameMatcher.EcsShmidC63, GameMatcher.EcsShmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC65(e.ecsShmidC65.field0 + 1, 0); } 
}} 
public class S49System : ReactiveSystem<GameEntity> {
   public S49System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC96, GameMatcher.EcsShmidC6, GameMatcher.EcsShmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC96(e.ecsShmidC96.field0 + 1, 0); } 
}} 
public class S50System : ReactiveSystem<GameEntity> {
   public S50System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC19, GameMatcher.EcsShmidC80, GameMatcher.EcsShmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC19(e.ecsShmidC19.field0 + 1, 0); } 
}} 
public class S51System : ReactiveSystem<GameEntity> {
   public S51System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC87, GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC76));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC87(e.ecsShmidC87.field0 + 1, 0); } 
}} 
public class S52System : ReactiveSystem<GameEntity> {
   public S52System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC49, GameMatcher.EcsShmidC48));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); } 
}} 
public class S53System : ReactiveSystem<GameEntity> {
   public S53System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC76, GameMatcher.EcsShmidC59, GameMatcher.EcsShmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC76(e.ecsShmidC76.field0 + 1, 0); } 
}} 
public class S54System : ReactiveSystem<GameEntity> {
   public S54System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC32, GameMatcher.EcsShmidC70, GameMatcher.EcsShmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC32(e.ecsShmidC32.field0 + 1, 0); } 
}} 
public class S55System : ReactiveSystem<GameEntity> {
   public S55System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC87, GameMatcher.EcsShmidC92, GameMatcher.EcsShmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC87(e.ecsShmidC87.field0 + 1, 0); } 
}} 
public class S56System : ReactiveSystem<GameEntity> {
   public S56System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC87, GameMatcher.EcsShmidC68, GameMatcher.EcsShmidC96));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC87(e.ecsShmidC87.field0 + 1, 0); } 
}} 
public class S57System : ReactiveSystem<GameEntity> {
   public S57System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC34, GameMatcher.EcsShmidC98, GameMatcher.EcsShmidC82));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC34(e.ecsShmidC34.field0 + 1, 0); } 
}} 
public class S58System : ReactiveSystem<GameEntity> {
   public S58System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC43, GameMatcher.EcsShmidC14, GameMatcher.EcsShmidC37));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC43(e.ecsShmidC43.field0 + 1, 0); } 
}} 
public class S59System : ReactiveSystem<GameEntity> {
   public S59System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC55, GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC55(e.ecsShmidC55.field0 + 1, 0); } 
}} 
public class S60System : ReactiveSystem<GameEntity> {
   public S60System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC0, GameMatcher.EcsShmidC92, GameMatcher.EcsShmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC0(e.ecsShmidC0.field0 + 1, 0); } 
}} 
public class S61System : ReactiveSystem<GameEntity> {
   public S61System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC64, GameMatcher.EcsShmidC97, GameMatcher.EcsShmidC22));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC64(e.ecsShmidC64.field0 + 1, 0); } 
}} 
public class S62System : ReactiveSystem<GameEntity> {
   public S62System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC64, GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC80));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC64(e.ecsShmidC64.field0 + 1, 0); } 
}} 
public class S63System : ReactiveSystem<GameEntity> {
   public S63System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC38, GameMatcher.EcsShmidC81, GameMatcher.EcsShmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC38(e.ecsShmidC38.field0 + 1, 0); } 
}} 
public class S64System : ReactiveSystem<GameEntity> {
   public S64System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC77, GameMatcher.EcsShmidC25, GameMatcher.EcsShmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC77(e.ecsShmidC77.field0 + 1, 0); } 
}} 
public class S65System : ReactiveSystem<GameEntity> {
   public S65System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC47, GameMatcher.EcsShmidC97, GameMatcher.EcsShmidC20));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC47(e.ecsShmidC47.field0 + 1, 0); } 
}} 
public class S66System : ReactiveSystem<GameEntity> {
   public S66System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC69, GameMatcher.EcsShmidC99, GameMatcher.EcsShmidC67));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC69(e.ecsShmidC69.field0 + 1, 0); } 
}} 
public class S67System : ReactiveSystem<GameEntity> {
   public S67System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC0, GameMatcher.EcsShmidC76, GameMatcher.EcsShmidC41));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC0(e.ecsShmidC0.field0 + 1, 0); } 
}} 
public class S68System : ReactiveSystem<GameEntity> {
   public S68System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC62, GameMatcher.EcsShmidC2, GameMatcher.EcsShmidC14));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC62(e.ecsShmidC62.field0 + 1, 0); } 
}} 
public class S69System : ReactiveSystem<GameEntity> {
   public S69System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC46, GameMatcher.EcsShmidC39, GameMatcher.EcsShmidC30));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC46(e.ecsShmidC46.field0 + 1, 0); } 
}} 
public class S70System : ReactiveSystem<GameEntity> {
   public S70System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC7, GameMatcher.EcsShmidC30, GameMatcher.EcsShmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC7(e.ecsShmidC7.field0 + 1, 0); } 
}} 
public class S71System : ReactiveSystem<GameEntity> {
   public S71System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC10, GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC62));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC10(e.ecsShmidC10.field0 + 1, 0); } 
}} 
public class S72System : ReactiveSystem<GameEntity> {
   public S72System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC97, GameMatcher.EcsShmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); } 
}} 
public class S73System : ReactiveSystem<GameEntity> {
   public S73System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC98, GameMatcher.EcsShmidC16, GameMatcher.EcsShmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC98(e.ecsShmidC98.field0 + 1, 0); } 
}} 
public class S74System : ReactiveSystem<GameEntity> {
   public S74System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC60, GameMatcher.EcsShmidC70, GameMatcher.EcsShmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC60(e.ecsShmidC60.field0 + 1, 0); } 
}} 
public class S75System : ReactiveSystem<GameEntity> {
   public S75System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC67, GameMatcher.EcsShmidC77));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC33(e.ecsShmidC33.field0 + 1, 0); } 
}} 
public class S76System : ReactiveSystem<GameEntity> {
   public S76System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC54(e.ecsShmidC54.field0 + 1, 0); } 
}} 
public class S77System : ReactiveSystem<GameEntity> {
   public S77System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC96, GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC88));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC96(e.ecsShmidC96.field0 + 1, 0); } 
}} 
public class S78System : ReactiveSystem<GameEntity> {
   public S78System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC25, GameMatcher.EcsShmidC91, GameMatcher.EcsShmidC39));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC25(e.ecsShmidC25.field0 + 1, 0); } 
}} 
public class S79System : ReactiveSystem<GameEntity> {
   public S79System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC51(e.ecsShmidC51.field0 + 1, 0); } 
}} 
public class S80System : ReactiveSystem<GameEntity> {
   public S80System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC47, GameMatcher.EcsShmidC56, GameMatcher.EcsShmidC66));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC47(e.ecsShmidC47.field0 + 1, 0); } 
}} 
public class S81System : ReactiveSystem<GameEntity> {
   public S81System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC57, GameMatcher.EcsShmidC15, GameMatcher.EcsShmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC57(e.ecsShmidC57.field0 + 1, 0); } 
}} 
public class S82System : ReactiveSystem<GameEntity> {
   public S82System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC28(e.ecsShmidC28.field0 + 1, 0); } 
}} 
public class S83System : ReactiveSystem<GameEntity> {
   public S83System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC2, GameMatcher.EcsShmidC75, GameMatcher.EcsShmidC70));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC2(e.ecsShmidC2.field0 + 1, 0); } 
}} 
public class S84System : ReactiveSystem<GameEntity> {
   public S84System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC29, GameMatcher.EcsShmidC75, GameMatcher.EcsShmidC28));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC29(e.ecsShmidC29.field0 + 1, 0); } 
}} 
public class S85System : ReactiveSystem<GameEntity> {
   public S85System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC0, GameMatcher.EcsShmidC9, GameMatcher.EcsShmidC90));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC0(e.ecsShmidC0.field0 + 1, 0); } 
}} 
public class S86System : ReactiveSystem<GameEntity> {
   public S86System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC80, GameMatcher.EcsShmidC7, GameMatcher.EcsShmidC29));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC80(e.ecsShmidC80.field0 + 1, 0); } 
}} 
public class S87System : ReactiveSystem<GameEntity> {
   public S87System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC4, GameMatcher.EcsShmidC42));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); } 
}} 
public class S88System : ReactiveSystem<GameEntity> {
   public S88System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC9, GameMatcher.EcsShmidC65, GameMatcher.EcsShmidC30));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC9(e.ecsShmidC9.field0 + 1, 0); } 
}} 
public class S89System : ReactiveSystem<GameEntity> {
   public S89System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC62));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC35(e.ecsShmidC35.field0 + 1, 0); } 
}} 
public class S90System : ReactiveSystem<GameEntity> {
   public S90System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC69, GameMatcher.EcsShmidC16));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC27(e.ecsShmidC27.field0 + 1, 0); } 
}} 
public class S91System : ReactiveSystem<GameEntity> {
   public S91System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC92, GameMatcher.EcsShmidC73, GameMatcher.EcsShmidC60));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC92(e.ecsShmidC92.field0 + 1, 0); } 
}} 
public class S92System : ReactiveSystem<GameEntity> {
   public S92System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC31, GameMatcher.EcsShmidC60, GameMatcher.EcsShmidC52));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC31(e.ecsShmidC31.field0 + 1, 0); } 
}} 
public class S93System : ReactiveSystem<GameEntity> {
   public S93System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC12, GameMatcher.EcsShmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC24(e.ecsShmidC24.field0 + 1, 0); } 
}} 
public class S94System : ReactiveSystem<GameEntity> {
   public S94System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC55, GameMatcher.EcsShmidC45, GameMatcher.EcsShmidC54));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC55(e.ecsShmidC55.field0 + 1, 0); } 
}} 
public class S95System : ReactiveSystem<GameEntity> {
   public S95System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC52, GameMatcher.EcsShmidC59, GameMatcher.EcsShmidC93));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC52(e.ecsShmidC52.field0 + 1, 0); } 
}} 
public class S96System : ReactiveSystem<GameEntity> {
   public S96System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC6, GameMatcher.EcsShmidC86, GameMatcher.EcsShmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC6(e.ecsShmidC6.field0 + 1, 0); } 
}} 
public class S97System : ReactiveSystem<GameEntity> {
   public S97System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC82, GameMatcher.EcsShmidC12, GameMatcher.EcsShmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC82(e.ecsShmidC82.field0 + 1, 0); } 
}} 
public class S98System : ReactiveSystem<GameEntity> {
   public S98System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC51(e.ecsShmidC51.field0 + 1, 0); } 
}} 
public class S99System : ReactiveSystem<GameEntity> {
   public S99System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC31, GameMatcher.EcsShmidC24));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC13(e.ecsShmidC13.field0 + 1, 0); } 
}} 
public class S100System : ReactiveSystem<GameEntity> {
   public S100System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC68, GameMatcher.EcsShmidC57));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC24(e.ecsShmidC24.field0 + 1, 0); } 
}} 
public class S101System : ReactiveSystem<GameEntity> {
   public S101System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC17, GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC23));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC17(e.ecsShmidC17.field0 + 1, 0); } 
}} 
public class S102System : ReactiveSystem<GameEntity> {
   public S102System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC59, GameMatcher.EcsShmidC31));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC35(e.ecsShmidC35.field0 + 1, 0); } 
}} 
public class S103System : ReactiveSystem<GameEntity> {
   public S103System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC9, GameMatcher.EcsShmidC56, GameMatcher.EcsShmidC70));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC9(e.ecsShmidC9.field0 + 1, 0); } 
}} 
public class S104System : ReactiveSystem<GameEntity> {
   public S104System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC12, GameMatcher.EcsShmidC6, GameMatcher.EcsShmidC83));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC12(e.ecsShmidC12.field0 + 1, 0); } 
}} 
public class S105System : ReactiveSystem<GameEntity> {
   public S105System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC69, GameMatcher.EcsShmidC1, GameMatcher.EcsShmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC69(e.ecsShmidC69.field0 + 1, 0); } 
}} 
public class S106System : ReactiveSystem<GameEntity> {
   public S106System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC96, GameMatcher.EcsShmidC30, GameMatcher.EcsShmidC21));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC96(e.ecsShmidC96.field0 + 1, 0); } 
}} 
public class S107System : ReactiveSystem<GameEntity> {
   public S107System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC52, GameMatcher.EcsShmidC62, GameMatcher.EcsShmidC61));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC52(e.ecsShmidC52.field0 + 1, 0); } 
}} 
public class S108System : ReactiveSystem<GameEntity> {
   public S108System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC27(e.ecsShmidC27.field0 + 1, 0); } 
}} 
public class S109System : ReactiveSystem<GameEntity> {
   public S109System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC21, GameMatcher.EcsShmidC48, GameMatcher.EcsShmidC0));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC21(e.ecsShmidC21.field0 + 1, 0); } 
}} 
public class S110System : ReactiveSystem<GameEntity> {
   public S110System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC49, GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC58));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC49(e.ecsShmidC49.field0 + 1, 0); } 
}} 
public class S111System : ReactiveSystem<GameEntity> {
   public S111System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC36, GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC89));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC36(e.ecsShmidC36.field0 + 1, 0); } 
}} 
public class S112System : ReactiveSystem<GameEntity> {
   public S112System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC71, GameMatcher.EcsShmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC93(e.ecsShmidC93.field0 + 1, 0); } 
}} 
public class S113System : ReactiveSystem<GameEntity> {
   public S113System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC91, GameMatcher.EcsShmidC62, GameMatcher.EcsShmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC91(e.ecsShmidC91.field0 + 1, 0); } 
}} 
public class S114System : ReactiveSystem<GameEntity> {
   public S114System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC37, GameMatcher.EcsShmidC27));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC24(e.ecsShmidC24.field0 + 1, 0); } 
}} 
public class S115System : ReactiveSystem<GameEntity> {
   public S115System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC7, GameMatcher.EcsShmidC74, GameMatcher.EcsShmidC94));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC7(e.ecsShmidC7.field0 + 1, 0); } 
}} 
public class S116System : ReactiveSystem<GameEntity> {
   public S116System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC69, GameMatcher.EcsShmidC7, GameMatcher.EcsShmidC95));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC69(e.ecsShmidC69.field0 + 1, 0); } 
}} 
public class S117System : ReactiveSystem<GameEntity> {
   public S117System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC40, GameMatcher.EcsShmidC7, GameMatcher.EcsShmidC6));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC40(e.ecsShmidC40.field0 + 1, 0); } 
}} 
public class S118System : ReactiveSystem<GameEntity> {
   public S118System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC74, GameMatcher.EcsShmidC61, GameMatcher.EcsShmidC64));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC74(e.ecsShmidC74.field0 + 1, 0); } 
}} 
public class S119System : ReactiveSystem<GameEntity> {
   public S119System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC67, GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC7));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC67(e.ecsShmidC67.field0 + 1, 0); } 
}} 
public class S120System : ReactiveSystem<GameEntity> {
   public S120System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC65, GameMatcher.EcsShmidC10, GameMatcher.EcsShmidC23));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC65(e.ecsShmidC65.field0 + 1, 0); } 
}} 
public class S121System : ReactiveSystem<GameEntity> {
   public S121System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC76, GameMatcher.EcsShmidC86));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); } 
}} 
public class S122System : ReactiveSystem<GameEntity> {
   public S122System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC30, GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC15));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC30(e.ecsShmidC30.field0 + 1, 0); } 
}} 
public class S123System : ReactiveSystem<GameEntity> {
   public S123System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC72, GameMatcher.EcsShmidC31, GameMatcher.EcsShmidC74));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC72(e.ecsShmidC72.field0 + 1, 0); } 
}} 
public class S124System : ReactiveSystem<GameEntity> {
   public S124System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC76, GameMatcher.EcsShmidC5, GameMatcher.EcsShmidC79));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC76(e.ecsShmidC76.field0 + 1, 0); } 
}} 
public class S125System : ReactiveSystem<GameEntity> {
   public S125System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC10, GameMatcher.EcsShmidC53, GameMatcher.EcsShmidC84));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC10(e.ecsShmidC10.field0 + 1, 0); } 
}} 
public class S126System : ReactiveSystem<GameEntity> {
   public S126System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC74, GameMatcher.EcsShmidC72, GameMatcher.EcsShmidC66));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC74(e.ecsShmidC74.field0 + 1, 0); } 
}} 
public class S127System : ReactiveSystem<GameEntity> {
   public S127System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC40, GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC26));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC40(e.ecsShmidC40.field0 + 1, 0); } 
}} 
public class S128System : ReactiveSystem<GameEntity> {
   public S128System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC91, GameMatcher.EcsShmidC40));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC85(e.ecsShmidC85.field0 + 1, 0); } 
}} 
public class S129System : ReactiveSystem<GameEntity> {
   public S129System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC30, GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC50));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC30(e.ecsShmidC30.field0 + 1, 0); } 
}} 
public class S130System : ReactiveSystem<GameEntity> {
   public S130System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC16, GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC82));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC16(e.ecsShmidC16.field0 + 1, 0); } 
}} 
public class S131System : ReactiveSystem<GameEntity> {
   public S131System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC38, GameMatcher.EcsShmidC58, GameMatcher.EcsShmidC40));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC38(e.ecsShmidC38.field0 + 1, 0); } 
}} 
public class S132System : ReactiveSystem<GameEntity> {
   public S132System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC96, GameMatcher.EcsShmidC9, GameMatcher.EcsShmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC96(e.ecsShmidC96.field0 + 1, 0); } 
}} 
public class S133System : ReactiveSystem<GameEntity> {
   public S133System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC58, GameMatcher.EcsShmidC79, GameMatcher.EcsShmidC72));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC58(e.ecsShmidC58.field0 + 1, 0); } 
}} 
public class S134System : ReactiveSystem<GameEntity> {
   public S134System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC12, GameMatcher.EcsShmidC9, GameMatcher.EcsShmidC68));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC12(e.ecsShmidC12.field0 + 1, 0); } 
}} 
public class S135System : ReactiveSystem<GameEntity> {
   public S135System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC27, GameMatcher.EcsShmidC64, GameMatcher.EcsShmidC33));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC27(e.ecsShmidC27.field0 + 1, 0); } 
}} 
public class S136System : ReactiveSystem<GameEntity> {
   public S136System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC16, GameMatcher.EcsShmidC44, GameMatcher.EcsShmidC8));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC16(e.ecsShmidC16.field0 + 1, 0); } 
}} 
public class S137System : ReactiveSystem<GameEntity> {
   public S137System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC31, GameMatcher.EcsShmidC47, GameMatcher.EcsShmidC36));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC31(e.ecsShmidC31.field0 + 1, 0); } 
}} 
public class S138System : ReactiveSystem<GameEntity> {
   public S138System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC56, GameMatcher.EcsShmidC69));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC20(e.ecsShmidC20.field0 + 1, 0); } 
}} 
public class S139System : ReactiveSystem<GameEntity> {
   public S139System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC90, GameMatcher.EcsShmidC38, GameMatcher.EcsShmidC78));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC90(e.ecsShmidC90.field0 + 1, 0); } 
}} 
public class S140System : ReactiveSystem<GameEntity> {
   public S140System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC83, GameMatcher.EcsShmidC67, GameMatcher.EcsShmidC1));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC83(e.ecsShmidC83.field0 + 1, 0); } 
}} 
public class S141System : ReactiveSystem<GameEntity> {
   public S141System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC70, GameMatcher.EcsShmidC38));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC85(e.ecsShmidC85.field0 + 1, 0); } 
}} 
public class S142System : ReactiveSystem<GameEntity> {
   public S142System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC84, GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC17));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC84(e.ecsShmidC84.field0 + 1, 0); } 
}} 
public class S143System : ReactiveSystem<GameEntity> {
   public S143System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC14, GameMatcher.EcsShmidC13));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC33(e.ecsShmidC33.field0 + 1, 0); } 
}} 
public class S144System : ReactiveSystem<GameEntity> {
   public S144System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC95, GameMatcher.EcsShmidC70, GameMatcher.EcsShmidC19));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC95(e.ecsShmidC95.field0 + 1, 0); } 
}} 
public class S145System : ReactiveSystem<GameEntity> {
   public S145System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC34, GameMatcher.EcsShmidC36, GameMatcher.EcsShmidC77));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC34(e.ecsShmidC34.field0 + 1, 0); } 
}} 
public class S146System : ReactiveSystem<GameEntity> {
   public S146System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC26, GameMatcher.EcsShmidC91, GameMatcher.EcsShmidC43));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC26(e.ecsShmidC26.field0 + 1, 0); } 
}} 
public class S147System : ReactiveSystem<GameEntity> {
   public S147System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC26, GameMatcher.EcsShmidC87, GameMatcher.EcsShmidC81));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC26(e.ecsShmidC26.field0 + 1, 0); } 
}} 
public class S148System : ReactiveSystem<GameEntity> {
   public S148System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC64, GameMatcher.EcsShmidC62));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC33(e.ecsShmidC33.field0 + 1, 0); } 
}} 
public class S149System : ReactiveSystem<GameEntity> {
   public S149System (GameContext context) : base(Contexts.sharedInstance.game){} 
   protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
       {return context.CreateCollector(GameMatcher.AllOf(GameMatcher.EcsShmidC32, GameMatcher.EcsShmidC6, GameMatcher.EcsShmidC11));} 
   protected override bool Filter(GameEntity entity) {return true;} 
   protected override void Execute(List<GameEntity> entities) { 
       foreach (var e in entities){ 
 e.ReplaceEcsShmidC32(e.ecsShmidC32.field0 + 1, 0); } 
}} 
public class S150System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S150System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC81, GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC35));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC81(e.ecsShmidC81.field0 + 1, 0); }
}}

public class S151System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S151System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC5, GameMatcher.EcsShmidC0, GameMatcher.EcsShmidC42));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC5(e.ecsShmidC5.field0 + 1, 0); }
}}

public class S152System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S152System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC98, GameMatcher.EcsShmidC16, GameMatcher.EcsShmidC81));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC98(e.ecsShmidC98.field0 + 1, 0); }
}}

public class S153System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S153System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC94));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC33(e.ecsShmidC33.field0 + 1, 0); }
}}

public class S154System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S154System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC56, GameMatcher.EcsShmidC70, GameMatcher.EcsShmidC90));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC56(e.ecsShmidC56.field0 + 1, 0); }
}}

public class S155System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S155System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC54, GameMatcher.EcsShmidC71, GameMatcher.EcsShmidC1));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC54(e.ecsShmidC54.field0 + 1, 0); }
}}

public class S156System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S156System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC14, GameMatcher.EcsShmidC9, GameMatcher.EcsShmidC88));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC14(e.ecsShmidC14.field0 + 1, 0); }
}}

public class S157System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S157System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC19, GameMatcher.EcsShmidC69, GameMatcher.EcsShmidC4));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC19(e.ecsShmidC19.field0 + 1, 0); }
}}

public class S158System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S158System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC47, GameMatcher.EcsShmidC74, GameMatcher.EcsShmidC70));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC47(e.ecsShmidC47.field0 + 1, 0); }
}}

public class S159System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S159System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC18, GameMatcher.EcsShmidC55, GameMatcher.EcsShmidC16));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC18(e.ecsShmidC18.field0 + 1, 0); }
}}

public class S160System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S160System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC5, GameMatcher.EcsShmidC39, GameMatcher.EcsShmidC46));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC5(e.ecsShmidC5.field0 + 1, 0); }
}}

public class S161System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S161System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC5, GameMatcher.EcsShmidC45, GameMatcher.EcsShmidC26));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC5(e.ecsShmidC5.field0 + 1, 0); }
}}

public class S162System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S162System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC87, GameMatcher.EcsShmidC31, GameMatcher.EcsShmidC85));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC87(e.ecsShmidC87.field0 + 1, 0); }
}}

public class S163System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S163System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC45, GameMatcher.EcsShmidC99));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC13(e.ecsShmidC13.field0 + 1, 0); }
}}

public class S164System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S164System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC71, GameMatcher.EcsShmidC52, GameMatcher.EcsShmidC79));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC71(e.ecsShmidC71.field0 + 1, 0); }
}}

public class S165System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S165System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC95, GameMatcher.EcsShmidC19, GameMatcher.EcsShmidC30));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC95(e.ecsShmidC95.field0 + 1, 0); }
}}

public class S166System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S166System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC22, GameMatcher.EcsShmidC52));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC20(e.ecsShmidC20.field0 + 1, 0); }
}}

public class S167System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S167System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC3, GameMatcher.EcsShmidC22, GameMatcher.EcsShmidC94));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC3(e.ecsShmidC3.field0 + 1, 0); }
}}

public class S168System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S168System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC42, GameMatcher.EcsShmidC52, GameMatcher.EcsShmidC85));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC42(e.ecsShmidC42.field0 + 1, 0); }
}}

public class S169System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S169System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC94, GameMatcher.EcsShmidC31, GameMatcher.EcsShmidC34));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC94(e.ecsShmidC94.field0 + 1, 0); }
}}

public class S170System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S170System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC20, GameMatcher.EcsShmidC89, GameMatcher.EcsShmidC13));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC20(e.ecsShmidC20.field0 + 1, 0); }
}}

public class S171System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S171System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC48, GameMatcher.EcsShmidC4, GameMatcher.EcsShmidC60));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC48(e.ecsShmidC48.field0 + 1, 0); }
}}

public class S172System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S172System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC25, GameMatcher.EcsShmidC58));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC28(e.ecsShmidC28.field0 + 1, 0); }
}}

public class S173System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S173System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC44, GameMatcher.EcsShmidC39, GameMatcher.EcsShmidC29));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC44(e.ecsShmidC44.field0 + 1, 0); }
}}

public class S174System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S174System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC28, GameMatcher.EcsShmidC3, GameMatcher.EcsShmidC84));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC28(e.ecsShmidC28.field0 + 1, 0); }
}}

public class S175System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S175System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC42));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC24(e.ecsShmidC24.field0 + 1, 0); }
}}

public class S176System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S176System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC98));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC35(e.ecsShmidC35.field0 + 1, 0); }
}}

public class S177System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S177System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC35, GameMatcher.EcsShmidC44, GameMatcher.EcsShmidC82));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC35(e.ecsShmidC35.field0 + 1, 0); }
}}

public class S178System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S178System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC65, GameMatcher.EcsShmidC51, GameMatcher.EcsShmidC86));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC65(e.ecsShmidC65.field0 + 1, 0); }
}}

public class S179System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S179System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC68, GameMatcher.EcsShmidC42, GameMatcher.EcsShmidC3));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC68(e.ecsShmidC68.field0 + 1, 0); }
}}

public class S180System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S180System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC14, GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC22));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC14(e.ecsShmidC14.field0 + 1, 0); }
}}

public class S181System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S181System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC74, GameMatcher.EcsShmidC33, GameMatcher.EcsShmidC4));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC74(e.ecsShmidC74.field0 + 1, 0); }
}}

public class S182System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S182System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC13, GameMatcher.EcsShmidC76, GameMatcher.EcsShmidC55));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC13(e.ecsShmidC13.field0 + 1, 0); }
}}

public class S183System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S183System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC44, GameMatcher.EcsShmidC93, GameMatcher.EcsShmidC40));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC44(e.ecsShmidC44.field0 + 1, 0); }
}}

public class S184System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S184System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC55, GameMatcher.EcsShmidC77, GameMatcher.EcsShmidC65));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC55(e.ecsShmidC55.field0 + 1, 0); }
}}

public class S185System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S185System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC14, GameMatcher.EcsShmidC49, GameMatcher.EcsShmidC73));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC14(e.ecsShmidC14.field0 + 1, 0); }
}}

public class S186System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S186System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC32, GameMatcher.EcsShmidC5));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC24(e.ecsShmidC24.field0 + 1, 0); }
}}

public class S187System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S187System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC90, GameMatcher.EcsShmidC55, GameMatcher.EcsShmidC0));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC90(e.ecsShmidC90.field0 + 1, 0); }
}}

public class S188System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S188System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC66, GameMatcher.EcsShmidC68, GameMatcher.EcsShmidC87));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC66(e.ecsShmidC66.field0 + 1, 0); }
}}

public class S189System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S189System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC92, GameMatcher.EcsShmidC94, GameMatcher.EcsShmidC85));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC92(e.ecsShmidC92.field0 + 1, 0); }
}}

public class S190System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S190System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC25, GameMatcher.EcsShmidC46, GameMatcher.EcsShmidC55));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC25(e.ecsShmidC25.field0 + 1, 0); }
}}

public class S191System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S191System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC8, GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC42));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC8(e.ecsShmidC8.field0 + 1, 0); }
}}

public class S192System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S192System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC79, GameMatcher.EcsShmidC40, GameMatcher.EcsShmidC84));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC79(e.ecsShmidC79.field0 + 1, 0); }
}}

public class S193System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S193System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC15, GameMatcher.EcsShmidC92, GameMatcher.EcsShmidC38));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC15(e.ecsShmidC15.field0 + 1, 0); }
}}

public class S194System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S194System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC64, GameMatcher.EcsShmidC39, GameMatcher.EcsShmidC85));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC64(e.ecsShmidC64.field0 + 1, 0); }
}}

public class S195System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S195System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC52, GameMatcher.EcsShmidC41, GameMatcher.EcsShmidC51));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC52(e.ecsShmidC52.field0 + 1, 0); }
}}

public class S196System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S196System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC89, GameMatcher.EcsShmidC37, GameMatcher.EcsShmidC70));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC89(e.ecsShmidC89.field0 + 1, 0); }
}}

public class S197System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S197System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC16, GameMatcher.EcsShmidC24, GameMatcher.EcsShmidC53));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC16(e.ecsShmidC16.field0 + 1, 0); }
}}

public class S198System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S198System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC85, GameMatcher.EcsShmidC48, GameMatcher.EcsShmidC86));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC85(e.ecsShmidC85.field0 + 1, 0); }
}}

public class S199System : IExecuteSystem {
private readonly IGroup<GameEntity> _group;
public S199System (GameContext context){_group = context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsShmidC95, GameMatcher.EcsShmidC22, GameMatcher.EcsShmidC78));}
 public void Execute(){
  foreach (var e in _group.GetEntities()){
e.ReplaceEcsShmidC95(e.ecsShmidC95.field0 + 1, 0); }
}}


 }