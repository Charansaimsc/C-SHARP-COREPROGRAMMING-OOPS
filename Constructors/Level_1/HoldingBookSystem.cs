/*Hotel Booking System
o Create a HotelBooking class with attributes guestName, roomType, and
nights.
o Use default, parameterized, and copy constructors to initialize bookings.*/

using System;

class HotelBooking
{
    // Attributes
    public string GuestName;
    public string RoomType;
    public int Nights;

    // 1️⃣ Default Constructor
    public HotelBooking()
    {
        GuestName = "Unknown Guest";
        RoomType = "Standard";
        Nights = 1;
    }

    // 2️⃣ Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // 3️⃣ Copy Constructor
    public HotelBooking(HotelBooking booking)
    {
        GuestName = booking.GuestName;
        RoomType = booking.RoomType;
        Nights = booking.Nights;
    }

    // Method to display booking details
    public void DisplayBooking()
    {
        Console.WriteLine("Guest Name : " + GuestName);
        Console.WriteLine("Room Type  : " + RoomType);
        Console.WriteLine("Nights     : " + Nights);
        Console.WriteLine();
    }
}

