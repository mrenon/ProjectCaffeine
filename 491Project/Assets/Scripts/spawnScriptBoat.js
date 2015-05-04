// Variable to store the enemy prefab
public var enemy : GameObject;
public var nightenemy : GameObject;
public var timer : float;
var tempenemy : GameObject;
var tempnight : GameObject;	
var check = 1;


// Variable to know how fast we should create new enemies
public var spawnTime : float = 0;
var number = Random.Range(9,9);


function Start() {  
    // Call the 'addEnemy' function every 'spawnTime' seconds
    number = Random.Range(1,0);
  //  InvokeRepeating("addEnemy", number, number);
    tempenemy = enemy;
	tempnight = nightenemy;

}

function Update() {

	timer -= Time.deltaTime;
	if(timer <= 0) {
	
		enemy = tempnight;
		if(check == 1) {
		Instantiate(enemy, transform.position, transform.rotation);
		check = 0;
		}
	}
	
	if(timer <= -35) {
		while(timer <= 0) {
		
			
			timer += 67;
			enemy = tempenemy;
			check = 1;
		}
	}
}

function FixedUpdate() {
	number = Random.Range(5,9);
}

// New function to spawn an enemy
function addEnemy() {  
    // Variables to store the X position of the spawn object
    // See image below
    var x1 = transform.position.x - GetComponent.<Renderer>().bounds.size.x/2;
    var x2 = transform.position.x + GetComponent.<Renderer>().bounds.size.x/2;

    // Randomly pick a point within the spawn object
    var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

    // Create an enemy at the 'spawnPoint' position
  //  Instantiate(enemy, spawnPoint, Quaternion.identity);
}