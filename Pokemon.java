import java.util.Scanner;
import java.lang.Thread;

public class Pokemon {	
    static int health = 1;							
    public static void main(String[] args) throws InterruptedException {								
		Scanner input = new Scanner(System.in);

		while (true) {
			System.out.print("\033[H\033[2J");
			System.out.flush();	
			
			System.out.println("==========");
            if (health == 1) {
			    System.out.print("= 	 =");
                System.out.println("\t\t #Health 1");
            }
            if (health <= 0) {
                System.out.print("= 	 =");
                System.out.println("\t\t #Dead");
            }
			System.out.println("=   	=");
			System.out.println("=      =");
			System.out.println("=======");
            
			System.out.println("[1] Attack\n[2] Revive Enemy");
			System.out.print("Choice: ");
			int choice = input.nextInt();
			
			switch (choice) {
				case 1:
                    if (health == 0) {
                        input.nextLine();
                        System.out.print("\033[H\033[2J");										
                        System.out.flush();
                        System.out.println("The enemy is already dead.");
                        System.out.println("(Press Enter to Continue)");
                        input.nextLine();
                    }
                    while (health != 0) {
                        for (int j = 1; j < 20; j++){
                            Thread.sleep(20);
                            System.out.print("\033[H\033[2J");										
                            System.out.flush();
                            System.out.println("==========");
                            System.out.print("=");
                            for (int k = 0; k < j; k++){
                                System.out.print(" ");
                            }
                            System.out.print("     =");
                            for (int a = 18; a > j; a--) {
                                System.out.print(" ");
                            }
                            System.out.println("#Health 1");
                            System.out.println("=       =");
                            System.out.println("=======");
                            
                        }
                        health--;    
                    }
					break;
                case 2:
                    input.nextLine();
                    System.out.print("\033[H\033[2J");										
                    System.out.flush();
                    if (health == 0)
                        System.out.println("REVIVING!!!");
                    if (health == 0) {
                        Thread.sleep(800);
                        System.out.println("The Mob has been revived!!!");
                        health = 1;
                    } else
                        System.out.println("There's no point the Mob is not dead.");
                    System.out.println("(Press Enter to Continue)");
                    input.nextLine();
                    break;
			}
			
		}
        
	}
}