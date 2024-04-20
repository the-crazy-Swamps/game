public class Gauge {
    private float hp;
    private float mp;

    public float Hp { 
        get { 
            return hp; 
        } 
    }

    public float DecreaseHp(float decreaseAmount) {
        if (this.hp - decreaseAmount <= 0) {
            this.hp = 0;
        } else {
            this.hp -= decreaseAmount;
        }
        return this.hp;
    }

}
