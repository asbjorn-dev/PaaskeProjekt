﻿using sheltermini.Shared;

namespace server.Repositories
{
    public interface IBookingRepos 
    {
        Booking[] getAll(Shelter s);
        void AddBook(Booking booking, Shelter s);
       
    }
}
