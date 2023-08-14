using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBG.Dtos.Weapon;

namespace MyBG.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>>AddWeapon(AddWeaponDto newWeapon);
    }
}