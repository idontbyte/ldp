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

        }

        private void EnemyTurn() {

        }

        private void RollInitiative() {
            var _warriorInitiative = Dice.RollD20();
            var _enemyInitiative = Dice.RollD20();
        }
    }
}
