﻿// <copyright file="AbonamentRepository.cs" company="Transilvania University Of Brasov">
// Fintineru Raduca-Maria
// </copyright>
// <summary> Defines the Abonament Repository class. </summary>

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TelecomManagement.Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelecomManagement.Data;


namespace TelecomManagement.Data
{
    /// <summary>
    /// AbonamentRepository class.
    /// </summary>
    
    public class AbonamentRepository : RepositoryBase<Abonament>
    {
        /// <summary>
        /// Initializes a new instance of the AbonamentRepository class.
        /// </summary>
        
        public AbonamentRepository(TelecomContext context) : base(context)
        {
        }


    }
    }

