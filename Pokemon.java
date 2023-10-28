// Made By: Harvey
// Pokemon SelfMade

import java.util.Scanner;
import java.lang.Thread;

public class Pokemon {
    static int player = 300;
    static int damage = 50;							
    static int eHealth = 200;
    static int eDamage = 50;
    public static void main(String[] args) throws InterruptedException { // Main Method							
		Scanner input = new Scanner(System.in);
        
		while (true) {
			start();
			switch (pChoice(input)) {
                case 0:
                    exit();
                    break;
				case 1:
                    eHealthChecker(input);
                    playerAttack();
                    enemyAttack();
					break;
				case 2:
                    playerBuff(input);
                    enemyAttack();
					break;
				case 3:
					eHeal(input);
					break;
                case 4:
                    eRevive(input);
                    break;
			}
		}
    }

    public static void start() { // Start Method first display in the game
        System.out.print("\033[H\033[2J");
        System.out.flush();
        System.out.println("\tBob");	
        System.out.println("      /\\   /\\");
        System.out.println("     /  \\ /  \\"); 
        if (eHealth <= 200 && eHealth != 0) {
            System.out.println("     \\\\   0   /\t\t\t _________  ");
            System.out.println("      \\\\  -  /\t\t\t/         \\ ");
            System.out.println("       |   |\t\t\t|  O   O  |");
            System.out.println("       /   \\\\\t\t\t|    |    |");
            System.out.println("      /     \\\\\t\t\t|  \\___/  |");
            System.out.println("     /       \\\\\t\t\t \\_______/ ");
            System.out.println("     Health " + player +"\t\t\t Health " + eHealth);
        } else if (eHealth <= 0) {
            System.out.println("     \\\\   0   /\t\t\t _________  ");
            System.out.println("      \\\\  -  /\t\t\t/         \\ ");
            System.out.println("       |   |\t\t\t|  X   X  |");
            System.out.println("       /   \\\\\t\t\t|    |    |");
            System.out.println("      /     \\\\\t\t\t|   ___   |");
            System.out.println("     /       \\\\\t\t\t \\_______/ ");
            System.out.println("     Health " + player +"\t\t\t  Dead " + eHealth);
        }
    }

    public static void exit() { // Exit Game Method
        System.out.print("\033[H\033[2J");										
        System.out.flush();
        System.out.println("Exited The Game Successfully!");
        System.exit(0);
    }

    public static int pChoice(Scanner input) { // Player Choice Method
        System.out.println("\n[1] Attack(" + damage + ")\n[2] Buff Attack(add 50)\n[3] Heal Enemy(heal 50)\n[4] Revive Enemy\n\n[0] Exit");
		System.out.print("Choice: ");
		int choice = input.nextInt();

        return choice;
    }

    public static void eHealthChecker(Scanner input) { // Enemy Health Checker Method
        if (eHealth <= 0) {
        input.nextLine();
        System.out.print("\033[H\033[2J");										
        System.out.flush();
        System.out.println("The enemy is already dead.");
        System.out.println("(Press Enter to Continue)");
        input.nextLine();
        }
    }

    public static void eHeal(Scanner input) { // Enemy Heal Method
        input.nextLine();
        System.out.print("\033[H\033[2J");										
        System.out.flush();
        if (eHealth == 0)
            System.out.println("Revive the enemy first to heal.");	
        else if (eHealth < 200) {
            eHealth += 50;
            System.out.println("Healed the enemy's hp for 50");
        }
        else 
            System.out.println("Enemy's health is full.");
        System.out.println("(Press enter to continue)");
        input.nextLine();
    }

    public static void eRevive(Scanner input) throws InterruptedException { // Enemy Revive Function
        input.nextLine();
        System.out.print("\033[H\033[2J");										
        System.out.flush();
        if (eHealth == 0)
            System.out.println("REVIVING!!!");
        if (eHealth == 0) {
            Thread.sleep(800);
            System.out.println("The Mob has been revived!!!");
            eHealth = 200;
            damage = 50;
        } else
            System.out.println("There's no point the Mob is not dead.");
        System.out.println("(Press Enter to Continue)");
        input.nextLine();
    }
    
    public static void playerAttack() throws InterruptedException { // Player Attack Method
        boolean checker = true;
        if (eHealth <= 0)
            checker = false;
        while (checker) {
            for (int j = 1; j < 20; j++){
                Thread.sleep(10);
                String eyes = "O";
                String space = "";
                if (j == 18)
                    eyes = "X";
                if (j == 19)
                    Thread.sleep(300);
                if (j == 18)
                    space = " ";
                if (j == 19)
                    space = "";
                System.out.print("\033[H\033[2J");										
                System.out.flush();
                System.out.println("\tBob");
                System.out.println("      /\\   /\\");
                System.out.println("     /  \\ /  \\");
                System.out.println("     \\\\   0   / \t\t" + space + " _________  ");
                System.out.println("      \\\\  -  / \t\t\t" + space + "/         \\ ");
                System.out.print("       |   |");
                for (int k = 0; k < j; k++){
                    System.out.print(" ");
                }
                System.out.print("=");
                for (int a = 18; a > j; a--) {
                        System.out.print(" ");
                }
                System.out.println(space+" |  "+eyes+"   "+eyes+"  |");
                System.out.println("       /   \\\\\t\t\t" + space + "|    |    |");
                System.out.println("      /     \\\\\t\t\t" + space + "|    "+eyes+"    |");
                System.out.println("     /       \\\\\t\t\t" + space + " \\_______/ ");
                System.out.println("     Health " + player +"\t\t\t Health " + eHealth);
                
            }
            checker = false;
            eHealth -= damage;
            if (eHealth < 0)
                eHealth = 0;
        }
    }

    public static void enemyAttack() throws InterruptedException { // Enemy Attack Function
        boolean pChecker = true;
        if (player <= 0)
            pChecker = false;
        if (eHealth <= 0)
            pChecker = false;
        while (pChecker) {
            for (int j = 20; j > 1; j--){
                Thread.sleep(10);
                String eyes = "O";
                String space = "";
                if (j == 1)
                    eyes = "X";
                if (j == 2)
                    Thread.sleep(300);
                if (j == 1)
                    space = " ";
                if (j == 2)
                    space = "";
                System.out.print("\033[H\033[2J");								
                System.out.flush();
                System.out.println("\tBob");
                System.out.println("      /\\   /\\");
                System.out.println("     /  \\ /  \\");
                System.out.println("     \\\\   0   / \t\t" + space + " _________  ");
                System.out.println("      \\\\  -  / \t\t\t" + space + "/         \\ ");
                System.out.print("       |   |");
                for (int k = 0; k < j; k++){
                    System.out.print(" ");
                }
                
                for (int a = 1; a > j; a++) {
                        System.out.print(" ");
                }
                System.out.print("=");
                for (int q = 19; q > j; q--) 
                    System.out.print(" ");
                System.out.println("|  "+eyes+"   "+eyes+"  |");
                System.out.println("       /   \\\\\t\t\t" + space + "|    |    |");
                System.out.println("      /     \\\\\t\t\t" + space + "|    "+eyes+"    |");
                System.out.println("     /       \\\\\t\t\t" + space + " \\_______/ ");
                System.out.println("     Health " + player +"\t\t\t Health " + eHealth);
                
            }
            pChecker = false;
            player -= eDamage;
            if (player < 0)
                eHealth = 0;
        }
    }

    public static void playerBuff(Scanner input) { // Player buff Method
        input.nextLine();
        System.out.print("\033[H\033[2J");										
        System.out.flush();
        damage += 50;
        System.out.println("Added 50 on damage!");
        input.nextLine();
    }
}


// Notice:
/* Needs the player to die if hp is 0 and cant attack when hp is 0
 * Add a player heal 
 */