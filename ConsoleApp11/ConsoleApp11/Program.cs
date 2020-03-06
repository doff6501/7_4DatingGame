using System;

    class Program
    {
        static void Main(string[] args)
        {
        DatingProfile Ted = new DatingProfile("Ted", "Dancing", 42, "Male");
        Ted.WriteBio("Loves the OutDoors");

        DatingProfile Babes = new DatingProfile("Babes", "Bunny", 39, "Female");
        Babes.WriteBio("Loves To Hike and Bike Ride");

        Ted.SendMessage("Hello Babes", "Wanna Take a Walk With Me",Babes);
        Babes.ReadMessage();
        }
    }

