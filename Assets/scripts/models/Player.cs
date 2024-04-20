public class Player {
    private int id;
    private string name;
    private int level;
    private float xp;
    private float money;
    private Gauge gauge;
    private PlayerClass playerClass;
    private Skill[] ownedSkills;
    private Inventory inventory;
    private CharacterModifier[] characterModifiers;

    public Player(string name) {
        this.name = name;
    }

    public int Id { get { return id; } }
    public string Name { get { return name; } }
    public int Level { get { return level; } }
    public float Xp { get { return xp; } }
    public float Money { get { return money; } }
    public Gauge Gauge { get { return gauge; } }
    public PlayerClass PlayerClass { get { return playerClass; } }
    public Skill[] OwnedSkills { get { return ownedSkills; } }
    public Inventory Inventory { get { return inventory; } }
    public CharacterModifier[] CharacterModifiers { get { return characterModifiers; } }

    public float Attack(Monster monster, float attackPoint) {
        monster.Gauge.DecreaseHp(attackPoint);
        return attackPoint;
    }

}
