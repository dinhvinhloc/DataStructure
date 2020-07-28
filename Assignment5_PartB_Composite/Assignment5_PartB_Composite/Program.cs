using System;

namespace Assignment5_PartB_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactComponent myFriends = new ContactGroup("Friends", "All my friends"); 
            ContactComponent myRelatives = new ContactGroup("Relatives", "All my relatives"); 
            ContactComponent allContact = new ContactGroup("All Contacts", "All My Contacts"); 
            
            allContact.add(myFriends); 
            
            myFriends.add(new Contact("Jack", "Baur", "jack.baur@somemail.com", "416-999-3333")); 
            myFriends.add(new Contact("George", "Mason", "George.mason@somemail.com", "416-999-3334")); 
            myFriends.add(new Contact("Nine", "Mason", "Nina.Mason@somemail.com", "416 - 999 - 3335"));
            
            allContact.add(myRelatives); 
            
            myRelatives.add(new Contact("Ron", "Baur", "jack.baur@somemail.com", "416 - 999 - 3333")); 
            myRelatives.add(new Contact("Rose", "Mason", "George.mason@somemail.com", "416 - 999 - 3334")); 
            myRelatives.add(new Contact("Ram", "Mason", "Nina.Mason@somemail.com", "416 - 999 - 3335")); 
            
            allContact.listContactDetails();
            Console.ReadLine();
        }
    }
}
