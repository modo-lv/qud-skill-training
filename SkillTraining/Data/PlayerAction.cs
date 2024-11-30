﻿namespace ModoMods.SkillTraining.Data {
  /// <summary>Player actions used in training skills.</summary>
  public enum PlayerAction {
    #region Melee combat
    AxeHit,
    CudgelHit,
    LongBladeHit,
    ShortBladeHit,
    SingleWeaponHit,
    OffhandWeaponHit,
    #endregion
    
    #region Missile combat
    BowOrRifleHit,
    PistolHit,
    HeavyWeaponHit,
    #endregion
    
    #region Cooking and Gathering
    Cook,
    CookTasty,
    Harvest,
    Butcher,
    #endregion
    
    #region Customs and Folklore
    FirstRitualRep,
    RitualRep,
    SecretReveal,
    #endregion
    
    Bandage,
    
    #region Tinkering
    ExamineSuccess,
    RifleTrashSuccess,
    #endregion
    
    ShieldBlock,
    
    Swim,
    
    ThrownWeaponHit,
    
    TradeItem,
    
    #region Wayfaring
    RegainBearings,
    WorldMapMove,
    #endregion
  }
}