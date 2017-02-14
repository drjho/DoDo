namespace DoDo.Models.GameModels
{
    public abstract class GameObject
    {
        static int counter { get; set; } = 0;

        public virtual string Name { get; set; }

        public int Id { get; set; }

        public GameObject(string name)
        {
            Name = name;
            Id = counter++;
        }

    }
}