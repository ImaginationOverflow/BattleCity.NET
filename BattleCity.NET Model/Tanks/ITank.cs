namespace BattleCityDotNETModel.Tanks
{
    public interface ITank
    {
        ///
        /// 
        /// 
        /// Texture (tank)
        /// Texture (bullet)
        /// Animation (bullet)
        /// 
        /// 
        /// Events
        ///  - OnHit
        ///  - OnDamaged
        ///  - OnDestroy
        ///  - OnSpawn
        ///  - OnMove
        ///  - Move
        ///  - Shoot
        ///
        ///  - ...
        /// 
        /// 
        
        
        int Life { get;  }

        string Name { get; }

        long Id { get;  }

        int Damage { get; }
    }
}
