import java.util.Scanner;
import java.util.ArrayList;
import java.lang.Thread;
import java.util.InputMismatchException;

public class Schedule {
    public static String[] daysWeek = {"SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"};
    static ArrayList<Store> actList = new ArrayList<>();
    private static String username , password;

    public static void main(String[] args) throws InterruptedException{
        Scanner input = new Scanner(System.in);
        
        Schedule s = new Schedule();
        User user = new User();
        s.login(input);

        while (true) {
            System.out.println("\n[1] Add Activities\n[2] Remove Activities\n[3] Display Activities\n[4] Exit");
            System.out.print("Choice: ");
            int choice = input.nextInt();
            input.nextLine();
            switch (choice) {
                case 1:
                    user.getActivities(actList, input);
                    break;
                case 2:
                    break;
                case 3:
                    user.displayActivities(actList);
                    break;
                case 4:
                    s.logout();
                    break;
                default:
                    System.out.println("Invalid Input. Select 1, 2, 3, or 4 only.");
                    break;
            }
        }
    }

    public void login(Scanner input) throws InterruptedException{ // User Log in method
        System.out.print("Username: ");
        username = input.nextLine();

        int checker = 0;
        boolean invalid = true;
        do {
            System.out.print("Password: ");
            password = input.nextLine(); 
            if (password.equals("harvey123"))
                invalid = false;
            if (invalid) {
                System.out.println("Incorrect Password.");
                checker++;
                if (checker == 3) {
                    System.out.println("\nPlease try again in: ");
                    for (int i = 5; i >= 1; i--) {
                        Thread.sleep(1000);
                        System.out.println(i);
                    }
                    checker = 0;
                }
            }
            
            
        } while(invalid);

        System.out.print("Loging in");
        for (int i = 3; i >= 1; i--) {
            Thread.sleep(800);
            System.out.print(".");
        }

        System.out.println("\nWelcome " + username + ", what do you want to do today?");
    }

    public void logout() throws InterruptedException{ // User Log out Method
        System.out.println("Exiting in");
        for (int i = 3; i >= 1; i--) {
            Thread.sleep(800);
            System.out.println(i + " ");
        }
        System.out.println("You have Successfully Logout your Account!");
        System.exit(0);
    }
}

class User extends Schedule { // user class extends schedule
    public String actName;
    public String month;
    public int day;

    public void getActivities(ArrayList<Store> actList, Scanner input) { // Method to get activites inputs
        System.out.print("Activity Name: ");
        actName = input.nextLine();

        System.out.print("Month: ");
        month = input.nextLine();

        do {
            try {
                do {
                    System.out.print("Number: ");
                    day = input.nextInt();
                    if (day > 31 || day <= 0)
                        System.out.println("Invalid Numberr.");
                } while(day <= 0);
            } catch (InputMismatchException e) {
                System.out.println("Invalid Number.");
                input.next();
            }
            
        } while(day > 31);
        
        Store store = new Store(actName, month, day);
        actList.add(store);
    }

    public void displayActivities(ArrayList<Store> actList) { // method to display the activities
        
        // if (actList.get(0).month.toUpperCase().equals("SUNDAY"))
        //     System.out.println(actList.get(0).month);

        System.out.println("<<<<<<<<<<<<< Activities >>>>>>>>>>>>>\n");

        System.out.println("======================================");
        for (int i = 0; i < actList.size(); i++) {
            System.out.println("\tActivity Name: " + actList.get(i).actName);
            System.out.println("\tOn: " + actList.get(i).month + " " + actList.get(i).day);
            System.out.println("======================================");
        }
    }
}

class Store { // class/object store
    public String actName;
    public String month;
    public int day;

    public Store (String actName, String month, int day) { // store constructor
        this.actName = actName;
        this.month = month;
        this.day = day;
    }
}


/*Create an Interactive Ai that can store and display your upcoming activities.

class Schedule
login() done 
logout() done 

class User extends Schedule
getActivities()
storeActivities()
removeActivities()
displaySchedule()

class Store */