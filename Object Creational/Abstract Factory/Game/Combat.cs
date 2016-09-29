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

            if (_warriorInitiative >= _enemyInitiative) {
                Turn(_warrior);
            } else if (_enemyInitiative > _warriorInitiative) {
                Turn(_enemy);
            } 
        }

        private void Turn(Warrior warrior) {
            
        }

        private void Turn(AbstractEnemy enemy) {

        }

        private void RollInitiative() {
            var _warriorInitiative = Dice.RollD20();
            var _enemyInitiative = Dice.RollD20();
        }
    }
}
