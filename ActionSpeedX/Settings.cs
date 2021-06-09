namespace ActionSpeedX
{
    public class Settings 
    {
        public bool Descriptions { get; set; } = false;
        public bool AttackSpeed { get; set; } = true;
        public bool MagickaRegen { get; set; } = false;
        public bool MoveSpeed { get; set; } = true;
        public bool PowerAttacks { get; set; } = false;
        public bool RangedAttack { get; set; } = true;
        public bool SpellCosts { get; set; } = true;
        public bool StaminaRegen { get; set; } = false;
        //public bool Creatures { get; set; } = false; <- some creatures have a problem during archery updates which causes them to vibrate in place while drawing on rare occasions.
        public bool Racials { get; set; } = true;
        public bool Factions { get; set; } = true;
        public bool BalancePerkMods { get; set; } = true;
        public bool CuirassOnly { get; set; } = false;

        private bool PatchOrdinator { get; set; } = false;
        private bool PatchVokrii { get; set; } = false;
        private bool PatchAdamant { get; set; } = false;
    }
}