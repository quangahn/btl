﻿using BTLwebNC.Models;

namespace BTLwebNC.Repository
{
    public interface IcontactRepository
    {
        TblContact sendContact(TblContact sendContact);
    }
}