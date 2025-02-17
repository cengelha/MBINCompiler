using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x10E77003B6CCDDA7, NameHash = 0xDD7401143C40F868)]
    public class GcRobotGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool ForceShowDebugMoveTrail;
        /* 0x0004 */ public GcCamouflageData RobotCamoData;
        /* 0x00A0 */ public NMSString0x10 ForceDroneWeapon;
        /* 0x00B0 */ public float MinInvestigateMessageTime;
        /* 0x00B4 */ public int MinRobotKillsForHint;
        /* 0x00B8 */ public float GrenadeLaunchFlightTime;
        /* 0x00BC */ public int AttackSentinelWantedValue;
        /* 0x00C0 */ public int MaxNumPatrolDrones;
        /* 0x00C4 */ public float UnderwaterPerceptionMargin;
        /* 0x00C8 */ public bool DronePatrolScanPlayer;
        /* 0x00CC */ public float DroneSearchPickNearbyTime;
        /* 0x00D0 */ public float DroneSearchPickNearbyAngleMin;
        /* 0x00D4 */ public float DroneSearchPickNearbyAngleMax;
        /* 0x00D8 */ public float DroneInvestigateMinWitnessRange;
        /* 0x00DC */ public float DroneInvestigateMinWitnessRangeCantSee;
        /* 0x00E0 */ public float DroneInvestigateMinChaseRange;
        /* 0x00E4 */ public float DroneInvestigateMinWitnessTime;
        /* 0x00E8 */ public float DroneInvestigateSpeedBoost;
        /* 0x00EC */ public float DroneInvestigateSpeedBoostStartDistance;
        /* 0x00F0 */ public float DroneInvestigateSpeedBoostRange;
        /* 0x00F4 */ public float DroneCrimePostInvestigateWaitTime;
        /* 0x00F8 */ public float EncounterRangeToBlockWantedSpawns;
        /* 0x00FC */ public float EncounterRangeToAllowPulledIntoFight;
        /* 0x0100 */ public bool DroneEnableVariableUpdate;
        /* 0x0104 */ public float DroneUpdateFPSMax;
        /* 0x0108 */ public float DroneUpdateFPSMin;
        /* 0x010C */ public float DroneUpdateDistForMax;
        /* 0x0110 */ public float DroneUpdateDistForMin;
        /* 0x0114 */ public float DroneAttackPlayerHeightOffset;
        /* 0x0118 */ public float DroneAttackMaxAngleDownFromPlayer;
        /* 0x011C */ public float DroneSpawnTime;
        /* 0x0120 */ public float DroneSpawnFadeTime;
        /* 0x0124 */ public float LineOfSightReturnCheckMinDistance;
        /* 0x0128 */ public float LineOfSightReturnCheckRadius;
        /* 0x012C */ public float LineOfSightReturnRange;
        /* 0x0130 */ public float FakeQuadGuard;
        /* 0x0134 */ public float RobotSightAngle;
        /* 0x0138 */ public float FriendlyDroneChatCooldown;
        /* 0x013C */ public float FriendlyDroneDissolveTime;
        /* 0x0140 */ public float FriendlyDroneChatChanceSummoned;
        /* 0x0144 */ public float FriendlyDroneChatChanceUnsummoned;
        /* 0x0148 */ public float FriendlyDroneChatChanceBecomeWanted;
        /* 0x014C */ public float FriendlyDroneChatChanceLoseWanted;
        /* 0x0150 */ public float FriendlyDroneChatChanceIdle;
        /* 0x0154 */ public float FriendlyDroneBeepReplaceChatChance;
        /* 0x0160 */ public Vector3f DroneRepairOffset;
        /* 0x0170 */ public float QuadLookAngleMin;
        /* 0x0174 */ public float QuadLookAngleMax;
        /* 0x0178 */ public Vector2f QuadLookTurnSpeeds;
        /* 0x0180 */ public float QuadAttackTurnAngleMin;
        /* 0x0184 */ public float QuadAttackTurnAngleMax;
        /* 0x0188 */ public Vector2f QuadAttackTurnSpeeds;
        /* 0x0190 */ public int DroneAggroDamage;
        /* 0x0194 */ public float CombatWaveSpawnTime;
        /* 0x0198 */ public float DronePerceptionMinHearingSpeed;
        /* 0x019C */ public float DroneSearchLookSpeed;
        /* 0x01A0 */ public float DroneSearchLookDistance;
        /* 0x01A4 */ public float DroneCrimeWitnessInvestigateDistance;
        /* 0x01A8 */ public bool DroneChatter;
        /* 0x01AC */ public float WalkerEnergyLength;
        /* 0x01B0 */ public float WalkerEnergySpeedMin;
        /* 0x01B4 */ public float WalkerEnergySpeedMax;
        /* 0x01B8 */ public float WalkerEnergyRadiusStartMin;
        /* 0x01BC */ public float WalkerEnergyRadiusStartMax;
        /* 0x01C0 */ public float WalkerEnergyMinAlpha;
        /* 0x01C4 */ public float WalkerEnergyMaxAlpha;
        /* 0x01C8 */ public float CriticalHitSizeDrone;
        /* 0x01CC */ public float CriticalHitSizeQuad;
        /* 0x01D0 */ public float CriticalHitSizeMech;
        /* 0x01D4 */ public float CriticalHitSizeWalker;
        /* 0x01D8 */ public float LabelOffsetDrone;
        /* 0x01DC */ public float LabelOffsetQuad;
        /* 0x01E0 */ public float LabelOffsetSpiderQuad;
        /* 0x01E4 */ public float LabelOffsetMech;
        /* 0x01E8 */ public float LabelOffsetWalker;
        /* 0x01F0 */ public Vector3f QuadCriticalOffset;
        /* 0x0200 */ public Vector3f DroneCriticalOffset;
        /* 0x0210 */ public Vector3f WalkerGunOffset1;
        /* 0x0220 */ public Vector3f WalkerGunOffset2;
        /* 0x0230 */ public float RobotSteeringFollowWeight;
        /* 0x0234 */ public float RobotSteeringAvoidTurnWeight;
        /* 0x0238 */ public float RobotSteeringAvoidCreaturesWeight;
        /* 0x023C */ public float RobotSteeringAvoidDangerWeight;
        /* 0x0240 */ public NMSString0x10 AttackScan;
        /* 0x0250 */ public float RobotHUDMarkerRange;
        /* 0x0254 */ public float RobotHUDMarkerFalloff;
        /* 0x0258 */ public float DroneMoveDistancePlayerMechMultiplier;
        /* 0x025C */ public float DroneSquadSpawnRadius;
        /* 0x0260 */ public float DroneSpawnHeight;
        /* 0x0264 */ public float DroneScale;
        /* 0x0268 */ public float TrackArrowOffsetMultiplier;
        /* 0x026C */ public float DroneCombatSpawnAngle;
        /* 0x0270 */ public float CombatSpawnSquadRadiusDrones;
        /* 0x0274 */ public float CombatSpawnSquadRadiusRobots;
        /* 0x0278 */ public float RobotMapScale;
        /* 0x027C */ public float WalkerLaserOvershootVehicleReducer;
        /* 0x0280 */ public bool DronesUseEscalationTimer;
        /* 0x0281 */ public bool DisableDronePerception;
        /* 0x0284 */ public float DroneHeightAngle;
        /* 0x0288 */ public float DroneAttackGetInRangeBoost;
        /* 0x028C */ public float DroneAggressiveInvestigateAttackTime;
        /* 0x0290 */ public float DronePushLaserForce;
        /* 0x0294 */ public float DronePushMaxSpeed;
        /* 0x0298 */ public float DronePushMaxTurn;
        /* 0x029C */ public float DroneCriminalScanTime;
        /* 0x02A0 */ public bool DroneClickToMove;
        /* 0x02A4 */ public float DroneInvestigateMinScanTime;
        /* 0x02A8 */ public float MedicDroneMinHealTime;
        /* 0x02B0 */ public GcScanEffectData DroneScanEffect;
        [NMS(Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0300 */ public int[] SentinelSpawnLimits;
        [NMS(Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x032C */ public GcSentinelResource[] SentinelResources;
        /* 0x0988 */ public float HeightTestSampleDistance;
        /* 0x098C */ public float HeightTestSampleTime;
        /* 0x0990 */ public float CollisionDistance;
        /* 0x0994 */ public float RobotSightTimer;
        /* 0x0998 */ public bool DroneHitImpulseEnabled;
        /* 0x099C */ public float DroneHitImpulseFlipForceDownBound;
        /* 0x09A0 */ public float DroneHitImpulseMinVerticalComponentScale;
        /* 0x09A4 */ public float DroneHitImpulseMultiplier;
        /* 0x09A8 */ public float DroneHitImpulseLaserMultiplier;
        /* 0x09AC */ public float DroneHitImpulseCooldown;
        /* 0x09B0 */ public float DroneReAttackTime;
        /* 0x09B4 */ public float DronePatrolAttackSightTime;
        /* 0x09B8 */ public float DronePatrolInvestigateSpeedBoost;
        /* 0x09BC */ public float DronePatrolSearchTime;
        /* 0x09C0 */ public int MaxNumInvestigatingDrones;
        /* 0x09C4 */ public float DroneCrimeCooldown;
        /* 0x09C8 */ public float DroneCrimeCooldownWaitTime;
        /* 0x09CC */ public float DroneCrimeCooldownWaitTimeAtMax;
        /* 0x09D0 */ public float DroneRadius;
        /* 0x09D4 */ public float DroneMaxScanLength;
        /* 0x09D8 */ public float DroneDecisionTime;
        /* 0x09DC */ public float DroneInvestigateMinPositionAngle;
        /* 0x09E0 */ public float DroneInvestigateMaxPositionAngle;
        /* 0x09E4 */ public float DroneInvestigateRepositionTime;
        /* 0x09E8 */ public float DroneInvestigateMinCrimeInterval;
        /* 0x09EC */ public float DroneScanRadius;
        /* 0x09F0 */ public float DroneMaxScanAngle;
        /* 0x09F4 */ public float DroneScanWaitTime;
        /* 0x09F8 */ public float DroneScanMinPerpSpeed;
        /* 0x09FC */ public float EnergyExplodeTime;
        /* 0x0A00 */ public float FollowRoutineArriveRadius;
        /* 0x0A04 */ public float CorruptedDroneRepairInteruptCooldownTime;
        /* 0x0A08 */ public float RepairCheckForTargetCooldownTime;
        /* 0x0A0C */ public float RepairOffsetChangeTime;
        /* 0x0A10 */ public float RepairOffset;
        /* 0x0A14 */ public float RepairScanArriveDistance;
        /* 0x0A18 */ public float RepairRate;
        /* 0x0A1C */ public float RepairScanRadius;
        /* 0x0A20 */ public float RepairChargeTime;
        /* 0x0A28 */ public NMSString0x10 RepairEffect;
        /* 0x0A38 */ public float RepairEffectScaleDrone;
        /* 0x0A3C */ public float RepairEffectScaleQuad;
        /* 0x0A40 */ public float MechFadeInTime;
        /* 0x0A44 */ public float MechFadeOutTime;
        /* 0x0A48 */ public float MechFadeInDistance;
        /* 0x0A4C */ public float ExoMechJumpCooldownTimeInCombat;
        /* 0x0A50 */ public float ExoMechJumpCooldownTimeOutOfCombat;
        /* 0x0A54 */ public float SentinelMechJumpCooldownTimeInCombat;
        /* 0x0A58 */ public float SentinelMechJumpCooldownTimeOutOfCombat;
        /* 0x0A5C */ public float MechStartJumpMinDistanceInCombat;
        /* 0x0A60 */ public float MechEndJumpMinDistanceInCombat;
        /* 0x0A64 */ public float MechStartJumpMinDistanceOutOfCombat;
        /* 0x0A68 */ public float MechEndJumpMinDistanceOutOfCombat;
        /* 0x0A6C */ public GcMechTargetSelectionWeightingSettings MechTargetSelectionWeightingSettings;
        /* 0x0A9C */ public float MechMinMaintainTargetTime;
        /* 0x0AA0 */ public float MechMinMaintainFireTargetTime;
        /* 0x0AA4 */ public float MechAttackRate;
        /* 0x0AA8 */ public float MechMinTurretAngle;
        /* 0x0AAC */ public float MechAttackMoveMinOffsetRotation;
        /* 0x0AB0 */ public float MechAttackMoveMaxOffsetRotation;
        /* 0x0AB4 */ public float MechAttackMoveHoldPositionTime;
        /* 0x0AB8 */ public float MechAttackMoveAngleToleranceDeg;
        /* 0x0ABC */ public float MechAttackMoveFacingAngleTolerance;
        /* 0x0AC0 */ public float MechAlertRange;
        /* 0x0AC4 */ public float MechAttackRange;
        /* 0x0AC8 */ public float MechSightRange;
        /* 0x0ACC */ public float MechSightAngle;
        /* 0x0AD0 */ public float MechHearingRange;
        /* 0x0AD4 */ public float MechPatrolRadius;
        /* 0x0AD8 */ public Vector2f MechPatrolPauseTime;
        [NMS(Size = 0x3, EnumType = typeof(GcSentinelMechWeaponMode.SentinelMechWeaponModeEnum))]
        /* 0x0AE0 */ public GcSentinelMechWeaponData[] SentinelMechWeaponData;
        /* 0x0C60 */ public float WalkerPauseTime;
        /* 0x0C64 */ public float WalkerAttackRange;
        /* 0x0C68 */ public float WalkerGuardAlertRange;
        /* 0x0C6C */ public float WalkerClosingRange;
        /* 0x0C70 */ public float WalkerAttackRate;
        /* 0x0C74 */ public float WalkerAttackAngle;
        /* 0x0C78 */ public float WalkerMoveSpeed;
        /* 0x0C7C */ public float WalkerFastMoveFactor;
        /* 0x0C80 */ public float WalkerHeight;
        /* 0x0C84 */ public float WalkerNavRadius;
        /* 0x0C88 */ public float WalkerPushTime;
        /* 0x0C8C */ public float WalkerPushRadius;
        /* 0x0C90 */ public float WalkerLaserOvershootStart;
        /* 0x0C94 */ public float WalkerLaserOvershootEnd;
        /* 0x0C98 */ public float WalkerLaserBodyOffset;
        /* 0x0C9C */ public float WalkerObstacleSize;
        /* 0x0CA0 */ public float WalkerGunShootTime;
        /* 0x0CA4 */ public float WalkerGunChargeTime;
        /* 0x0CA8 */ public float WalkerGunRate;
        /* 0x0CAC */ public float WalkerTitanFallHeight;
        /* 0x0CB0 */ public float WalkerTitanFallSpeed;
        /* 0x0CB8 */ public NMSString0x10 WalkerTitanFallEffect;
        /* 0x0CC8 */ public float WalkerTitanFallEffectScale;
        /* 0x0CD0 */ public NMSString0x10 WalkerTitanFallShake;
        /* 0x0CE0 */ public List<NMSString0x20> WalkerLeftLegArmourNodes;
        /* 0x0CF0 */ public List<NMSString0x20> WalkerRightLegArmourNodes;
        /* 0x0D00 */ public bool WalkerLegShotDefendEnabled;
        /* 0x0D04 */ public float WalkerLegShotDefendTime;
        /* 0x0D08 */ public bool WalkerLegShotEnrageEnabled;
        /* 0x0D0C */ public float WalkerLegShotEnrageShotInterval;
        /* 0x0D10 */ public int WalkerLegShotEnrageShotsPerVolley;
        /* 0x0D14 */ public float WalkerLegShotEnrageVolleyInterval;
        /* 0x0D18 */ public float WalkerLegShotEnrageShotSpreadMin;
        /* 0x0D1C */ public float WalkerLegShotEnrageShotSpreadMax;
        /* 0x0D20 */ public float WalkerHeadMoveTimeIdle;
        /* 0x0D24 */ public float WalkerHeadMoveTimeActive;
        /* 0x0D28 */ public float WalkerHeadMaxYaw;
        /* 0x0D2C */ public float WalkerHeadMaxPitch;
        /* 0x0D30 */ public Vector3f WalkerHeadEyeOffset;
        /* 0x0D40 */ public float SpiderPounceAngle;
        /* 0x0D44 */ public float SpiderPounceRange;
        /* 0x0D48 */ public float SpiderPounceMinRange;
        /* 0x0D4C */ public float QuadAlertRange;
        /* 0x0D50 */ public float QuadAttackMoveMinDist;
        /* 0x0D54 */ public float QuadAttackMoveRange;
        /* 0x0D58 */ public float QuadAttackMoveMinRange;
        /* 0x0D5C */ public float QuadStealthCooldown;
        /* 0x0D60 */ public int HitsToCancelStealthSmall;
        /* 0x0D64 */ public int HitsToCancelStealth;
        /* 0x0D68 */ public float QuadRepositionMaxTimeSinceHit;
        /* 0x0D6C */ public float QuadStealthRepositionMaxTimeSinceHit;
        /* 0x0D70 */ public float QuadRepositionHealthThresholdPercent;
        /* 0x0D74 */ public float QuadStealthRepositionHealthThresholdPercent;
        /* 0x0D78 */ public float QuadStealthRepositionHealthThresholdPercentSmall;
        /* 0x0D7C */ public float QuadRepositionTimeout;
        /* 0x0D80 */ public float QuadRepositionMinMoveDist;
        /* 0x0D84 */ public float QuadRepositionTargetDist;
        /* 0x0D88 */ public float QuadRepositionMinTargetDist;
        /* 0x0D8C */ public float QuadAttackMinMoveTime;
        /* 0x0D90 */ public float QuadJumpBackRecoveryTime;
        /* 0x0D94 */ public float QuadMinStationaryTime;
        /* 0x0D98 */ public float QuadJumpBackRange;
        /* 0x0D9C */ public float QuadJumpBackCheckRange;
        /* 0x0DA0 */ public float QuadJumpBackHeightRange;
        /* 0x0DA4 */ public float QuadJumpBackJumpDistance;
        /* 0x0DA8 */ public float QuadJumpBackJumpMinLength;
        /* 0x0DAC */ public float QuadJumpBackDoFlipDistance;
        /* 0x0DB0 */ public float QuadJumpBackMinTime;
        /* 0x0DB4 */ public float QuadJumpBackFacingAngle;
        /* 0x0DB8 */ public float QuadJumpBackTestRadius;
        /* 0x0DBC */ public float QuadJumpBackTestHeightOffset;
        /* 0x0DC0 */ public float QuadEvadeFacingAngle;
        /* 0x0DC4 */ public float QuadPounceOffset;
        /* 0x0DC8 */ public float QuadPounceDamageRadius;
        /* 0x0DCC */ public float QuadEvadeCooldown;
        /* 0x0DD0 */ public float QuadCannotSeeTargetRepositionTime;
        /* 0x0DD4 */ public int QuadDamageMoveThreshold;
        /* 0x0DD8 */ public float QuadAttackRate;
        /* 0x0DDC */ public float QuadLaserSpringMin;
        /* 0x0DE0 */ public float QuadLaserSpringMax;
        /* 0x0DE4 */ public float QuadTurnBlendTime;
        /* 0x0DE8 */ public float QuadHeight;
        /* 0x0DEC */ public float QuadNavRadius;
        /* 0x0DF0 */ public float QuadObstacleSize;
        /* 0x0DF4 */ public float QuadPatrolRadius;
        /* 0x0DF8 */ public Vector2f QuadPatrolPauseTime;
        /* 0x0E00 */ public float QuadHearingRange;
        /* 0x0E04 */ public float QuadSightRange;
        /* 0x0E08 */ public float QuadSightAngle;
        /* 0x0E0C */ public float SpiderQuadMiniObstacleSize;
        /* 0x0E10 */ public float SpiderQuadHeight;
        /* 0x0E14 */ public float SpiderQuadNavRadius;
        /* 0x0E18 */ public float SpiderQuadMiniHeight;
        /* 0x0E1C */ public float SpiderQuadMiniNavRadius;
        /* 0x0E20 */ public float SpiderQuadHeadTrackSmoothTime;
        /* 0x0E24 */ public float DronePerceptionRange;
        /* 0x0E28 */ public float DronePerceptionRangeHostile;
        /* 0x0E2C */ public float DronePerceptionSightRange;
        /* 0x0E30 */ public float DronePerceptionSightRangeHostile;
        /* 0x0E34 */ public float DronePerceptionSightAngle;
        /* 0x0E38 */ public bool SpawnFriendlyDrone;
        /* 0x0E3C */ public float AttackMoveMaxTime;
        /* 0x0E40 */ public float AttackMoveArrivalDistance;
        /* 0x0E44 */ public float LaserFadeTime;
        /* 0x0E48 */ public float LaserFadeTime2;
        /* 0x0E4C */ public int SummonerDroneResummonThreshold;
        /* 0x0E50 */ public float SummonerDroneCooldownOffset;
        /* 0x0E54 */ public float SummonerDroneCooldown;
        /* 0x0E58 */ public float SummonerDroneBeginTime;
        /* 0x0E5C */ public float SummonerDroneBuildupTime;
        /* 0x0E60 */ public NMSString0x10 SummonerDroneBuildupEffect;
        /* 0x0E70 */ public NMSString0x10 SummonerDroneSpawnEffect;
        /* 0x0E80 */ public float SummonRadius;
        /* 0x0E84 */ public float SummonVerticalOffset;
        /* 0x0E88 */ public float SummonPreviewInterpSpeedMin;
        /* 0x0E8C */ public float SummonPreviewInterpSpeedMax;
        /* 0x0E90 */ public bool SummonerTestSummonEffects;
        /* 0x0E94 */ public float FireRateLastHitBypassTime;
        /* 0x0E98 */ public float FireRateModifierMin;
        /* 0x0E9C */ public float FireRateModifierMax;
        /* 0x0EA0 */ public int ScoreForMinFireRateModifier;
        /* 0x0EA4 */ public int ScoreForMaxFireRateModifier;
        [NMS(Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0EA8 */ public float[] FireRateModifierScores;
        /* 0x0EE0 */ public GcRobotLaserData WalkerLaser;
        /* 0x0F30 */ public GcRobotLaserData QuadLaser;
        /* 0x0F80 */ public GcDroneData DroneControl;
        [NMS(Size = 0x4, EnumType = typeof(GcSentinelQuadWeaponMode.SentinelQuadWeaponModeEnum))]
        /* 0x1320 */ public GcSentinelQuadWeaponData[] QuadWeapons;
        /* 0x1640 */ public List<GcDroneWeaponData> DroneWeapons;
        [NMS(Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x1650 */ public GcSentinelDamagedData[] DamageData;
        [NMS(Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x1968 */ public GcSentinelPounceBalance[] PounceData;
    }
}
