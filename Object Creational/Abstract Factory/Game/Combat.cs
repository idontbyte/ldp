using System;

namespace AbstractFactory
{
    public class Combat
    {
        private Warrior _warrior;
        private int _warriorInitiative;

        private AbstractEnemy _enemy;
        private int _enemyInitiative;

        public Combat(Warrior warrior, AbstractEnemy enemy)
        {
            _warrior = warrior;
            _enemy = enemy;

            BeginCombat();
        }

        private void BeginCombat() {
            // roll for initiative
            RollInitiative();
            GameHelper.Pause();

            if (_warriorInitiative >= _enemyInitiative) {
                Console.WriteLine(string.Concat("You get the drop on the ",_enemy.Name));
                WarriorTurn();
            } else if (_enemyInitiative > _warriorInitiative) {
                Console.WriteLine(string.Concat("The ",_enemy.Name," takes you by surprise."));
                EnemyTurn();
            } 
        }

        private void WarriorTurn() {
            GameHelper.Pause();
            var roll = Dice.RollD20();
            var result = roll + _warrior.AttackBonus + _warrior.StrengthModifier;
            if (result > _enemy.ArmorClass) {
                // hit
                var damage = _warrior.Weapon.Damage + _warrior.StrengthModifier;
                Console.WriteLine(string.Concat("You hit the ",_enemy.Name," with your ",_warrior.Weapon.Name," striking it for ",damage," damage."));
                _enemy.HitPoints = _enemy.HitPoints - damage;
            } else {
                // miss
                Console.WriteLine(string.Concat("You miss the ",_enemy.Name," spectacularly."));
            }
        }

        private void EnemyTurn() {
            GameHelper.Pause();

        }

        private void RollInitiative() {
            _warriorInitiative = Dice.RollD20();
            _enemyInitiative = Dice.RollD20();
        }
    }
}
