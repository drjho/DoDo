namespace DoDo.Models.GameModels
{
    public class Room
    {
        public int Gold { get; set; }
        public Creature Occupier { get; set; }

        public bool IsOccupied => Occupier != null;

        public void HandleAttack(Creature attacker)
        {
            Occupier.AttackedBy(attacker);
        }
    }
}