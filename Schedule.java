// Made by: Harvey
// Schedule SelfMade

import java.util.Scanner;
import java.util.ArrayList;
import java.lang.Thread;
import java.util.InputMismatchException;

public class Schedule {
    static ArrayList<Store> actList = new ArrayList<>();
    private static String username , password;

    public static void main(String[] args) throws InterruptedException{
        Scanner input = new Scanner(System.in);
        System.out.print("\033[H\033[2J");
        System.out.flush();

        Schedule.login(input);
        while (true) {
            System.out.println("\n[1] Add Activities\n[2] Remove Activities\n[3] Display Activities\n[4] Exit");
            System.out.print("Choice: ");
            int choice = input.nextInt();
            input.nextLine();
            switch (choice) {
                case 1:
                    User.getActivities(actList, input);
                    break;
                case 2:
                    User.displayActivities(actList);
                    User.removeActivities(actList, input);
                    break;
                case 3:
                    User.displayActivities(actList);
                    break;
                case 4:
                    Schedule.logout();
                    break;
                default:
                    System.out.println("Invalid Input. Select 1, 2, 3, or 4 only.");
                    break;
            }
        }
    }

    public static void login(Scanner input) throws InterruptedException{ // User Log in method
        System.out.println("Welcome to Schedule App!");
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
                    System.out.print("\033[H\033[2J");
                    System.out.flush();
                    for (int i = 5; i >= 1; i--) {
                        System.out.print("\nPlease try again in: ");
                        System.out.print(i);
                        Thread.sleep(1000);
                        System.out.print("\033[H\033[2J");
                        System.out.flush();
                    }
                if (checker == 3)
                    System.out.println("Username: " + username);
                    checker = 0;
                }
            }    
        } while(invalid);

        System.out.print("Loging in");
        for (int i = 3; i >= 1; i--) {
            Thread.sleep(800);
            System.out.print(".");
        }
        System.out.print("\033[H\033[2J");
        System.out.flush();

        System.out.println("\nWelcome " + username + ", what do you want to do today?");
    }

    public static void logout() throws InterruptedException{ // User Log out Method
        for (int i = 3; i >= 1; i--) {
            System.out.print("Exiting in: ");
            System.out.println(i);
            Thread.sleep(800);
            System.out.print("\033[H\033[2J");
            System.out.flush();
        }
        System.out.println("You have Successfully Logout your Account!");
        System.exit(0);
    }
}

class User { // user class 
    public static String actName;
    public static String month;
    public static int day;

    public static void getActivities(ArrayList<Store> actList, Scanner input) { // Method to get activites inputs
        System.out.print("\033[H\033[2J");
        System.out.flush();

        System.out.print("Activity Name: ");
        actName = input.nextLine();

        System.out.print("Month Name: ");
        month = input.nextLine();

        do {
            try {
                do {
                    System.out.print("Number: ");
                    day = input.nextInt();
                    if (day > 31 || day <= 0)
                        System.out.println("Invalid Number.");
                } while(day <= 0);
            } catch (InputMismatchException e) {
                System.out.println("Invalid Number.");
                input.next();
            }
            
        } while(day > 31);
        
        Store store = new Store(actName, month, day);
        actList.add(store);
        System.out.print("\033[H\033[2J");
        System.out.flush();
    }

    public static void displayActivities(ArrayList<Store> actList) { // method to display the activities
        System.out.print("\033[H\033[2J");
        System.out.flush();

        System.out.println("<<<<<<<<<<<<< Activities >>>>>>>>>>>>>\n");
        System.out.println("======================================");
        for (int i = 0; i < actList.size(); i++) {
            System.out.println("[" + i + "]\tActivity Name: " + actList.get(i).actName);
            System.out.println("\tOn: " + actList.get(i).month + " " + actList.get(i).day);
            System.out.println("======================================");
        }
    }

    public static void removeActivities(ArrayList<Store> actList, Scanner input) { // method to remove an activity
        System.out.print("Select an index to remove: ");
        int del = input.nextInt();

        actList.remove(del);
        System.out.println("Activity Successfuly Removed.");
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

class User 
getActivities()
storeActivities()
removeActivities()
displaySchedule()

class Store */