using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tommy_Skrak_LexDo.Models
{
	public class AutoMapping : Profile
	{
		public AutoMapping()
		{
			CreateMap<Reminder, ReminderDto>();
			CreateMap<Group, GroupDto>();
			CreateMap<Reminder, ExcelReminder>();
		}
	}
}
