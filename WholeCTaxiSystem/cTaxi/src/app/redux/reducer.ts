import { Store } from "./store";
import { Action } from "./action";
import { ActionType } from "./action-type";

export class Reducer{
    public static reduce(oldStore: Store, action:Action):Store{
        let newStore:Store = {...oldStore};

        switch(action.type){
            case ActionType.GetAllDrivers:
                newStore.drivers = action.payload;
                break;
            case ActionType.AddDriver:
                newStore.drivers.push(action.payload);
                break;
            case ActionType.ClearAllDrivers:
                newStore.drivers=null;
                break;
            case ActionType.DeleteDriver:
                newStore.drivers.forEach( (item, index) => {
                    if(item === action.payload) newStore.drivers.splice(index,1);
                });
                break;
            case ActionType.UpdateDriver:
                let itemIndex = newStore.drivers.findIndex(item => item === action.payload);
                newStore.drivers[itemIndex] = action.payload;
                break;
            case ActionType.LogIn:
                newStore.isLoggedIn=true;
                break;
            case ActionType.LogOut:
                newStore.isLoggedIn=false;
                break;
            default:
                break;
        }

        return newStore;

    }
}