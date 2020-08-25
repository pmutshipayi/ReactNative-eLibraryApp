import { NavigationActions } from 'react-navigation';
import { NavigationStackProp } from 'react-navigation-stack';

let navigator: NavigationStackProp;

function setTopLevelNavigator(navigatorRef: any) {
    navigator = navigatorRef;
}

function navigate(routeName: string, params: any) {
    navigator.dispatch(
        NavigationActions.navigate({
            routeName
        })
    );
    console.log("navigate bro")
}

// add other navigation functions that you need and export them

export default {
    navigate,
    setTopLevelNavigator,
};