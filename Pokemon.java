// Made By: Harvey
// Pokemon SelfMade

import java.util.Scanner;
import java.lang.Thread;

public class Pokemon {	
    static int health = 200;
    static int damage = 50;							
    public static void main(String[] args) throws InterruptedException {								
		Scanner input = new Scanner(System.in);
		while (true) {
			System.out.print("\033[H\033[2J");
			System.out.flush();
			System.out.println("\tBob");	
			System.out.println("      /\\   /\\");
            System.out.println("     /  \\ /  \\"); 
            if (health <= 200 && health != 0) {
                System.out.println("     \\\\   0   /\t\t\t _________  ");
                System.out.println("      \\\\  -  /\t\t\t/         \\ ");
                System.out.println("       |   |\t\t\t|  O   O  |");
                System.out.println("       /   \\\\\t\t\t|    |    |");
                System.out.println("      /     \\\\\t\t\t|  \\___/  |");
                System.out.println("     /       \\\\\t\t\t \\_______/ ");
                System.out.println("\t\t\t\t  Health " + health);
            }
            else if (health <= 0) {
                System.out.println("     \\\\   0   /\t\t\t _________  ");
                System.out.println("      \\\\  -  /\t\t\t/         \\ ");
                System.out.println("       |   |\t\t\t|  X   X  |");
                System.out.println("       /   \\\\\t\t\t|    |    |");
                System.out.println("      /     \\\\\t\t\t|   ___   |");
                System.out.println("     /       \\\\\t\t\t \\_______/ ");
                System.out.println("\t\t\t\t  Dead " + health);
            }
            
			System.out.println("[1] Attack(" + damage + ")\n[2] Buff Attack(add 50)\n[3] Heal Enemy(heal 50)\n[4] Revive Enemy");
			System.out.print("Choice: ");
			int choice = input.nextInt();
			
			switch (choice) {
				case 1:
                    if (health <= 0) {
                        input.nextLine();
                        System.out.print("\033[H\033[2J");										
                        System.out.flush();
                        System.out.println("The enemy is already dead.");
                        System.out.println("(Press Enter to Continue)");
                        input.nextLine();
                    }
                    boolean checker = true;
                    if (health <= 0)
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
                            System.out.println("\t\t\t\t  Health " + health);
                            
                        }
                        checker = false;
                        health -= damage;
                        if (health < 0)
                        	health = 0;
                    }
					break;
				case 2:
					damage += 50;
					System.out.println("Added 50 on damage!");
					break;
				case 3:
					input.nextLine();
					System.out.print("\033[H\033[2J");										
                    System.out.flush();
					if (health == 0)
						System.out.println("Revive the enemy first to heal.");	
					else if (health < 200) {
						health += 50;
						System.out.println("Healed the enemy's hp for 50");
					}
					else 
						System.out.println("Enemy's health is full.");
					System.out.println("(Press enter to continue)");
					input.nextLine();
					break;
                case 4:
                    input.nextLine();
                    System.out.print("\033[H\033[2J");										
                    System.out.flush();
                    if (health == 0)
                        System.out.println("REVIVING!!!");
                    if (health == 0) {
                        Thread.sleep(800);
                        System.out.println("The Mob has been revived!!!");
                        health = 200;
                        damage = 50;
                    } else
                        System.out.println("There's no point the Mob is not dead.");
                    System.out.println("(Press Enter to Continue)");
                    input.nextLine();
                    break;
			}
		}
<<<<<<< HEAD
    }
=======
        
	}
>>>>>>> 373e8a4ce46bbd06e74129e6039ec66de94fb53d
}