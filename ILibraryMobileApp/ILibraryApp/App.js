/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 */

import React from 'react';
import { createAppContainer, createSwitchNavigator } from 'react-navigation';
import { createStackNavigator } from 'react-navigation-stack';
import { createBottomTabNavigator } from 'react-navigation-tabs';
import Icon from 'react-native-vector-icons/Feather'
import { default as FontAwesomeIcon } from 'react-native-vector-icons/FontAwesome'
import BookScreen from "./src/components/books/BookScreen";
import LibraryScreen from "./src/components/libraries/LibraryScreen";
import AccountScreen from "./src/components/accounts/AccountScreen";
import { Provider } from "mobx-react";
import BookDetailScreen from "./src/components/books/BookDetailScreen";
import { PrimaryColor } from "./src/AppConstant";
import LoginScreen from "./src/components/accounts/LoginScreen";
import RegistrationScreen from "./src/components/accounts/RegistrationScreen";
import authStore from "./src/stores/AuthStore";
import LoadingScreen from "./src/components/LoadingScreen";
import userStore from "./src/stores/UserStore";
import ProfileScreen from "./src/components/accounts/ProfileScreen";
import LibraryDetailScreen from './src/components/libraries/LibraryDetailScreen'
import BookSearchView from './src/components/books/BookSearchView'
import ServerConfig from './src/components/ServerConfig'



const bookNavigator = createStackNavigator({
    Home: BookScreen,
    Detail: BookDetailScreen,
    BookSearch: {
        screen: BookSearchView,
        navigationOptions: {
            header: null
        }
    }
}, { headerMode: 'screen' });

const authNavigator = createStackNavigator({
    Login: LoginScreen,
    SignUp: RegistrationScreen,
    SConfig: ServerConfig
});

const accountNavigator = createStackNavigator({
    Account: AccountScreen,
    Profile: {
        screen: ProfileScreen,
        navigationOptions: {
            header: null
        }
    }
}, { headerMode: 'screen' });

const libraryNavigator = createStackNavigator({
    Library: LibraryScreen,
    LibraryDetail: LibraryDetailScreen
})

const serverNavigator = createStackNavigator({
    ServerConfig: ServerConfig
});

const tabNavigator = createBottomTabNavigator({
    Books: bookNavigator,
    Libraries: libraryNavigator,
    Account: accountNavigator,
    Server: serverNavigator
},
    {
        defaultNavigationOptions: ({ navigation }) => ({
            tabBarIcon: ({ tintColor }) => {
                const { routeName } = navigation.state;
                let IconComponent = Icon;
                let iconName;
                switch (routeName) {
                    case 'Books':
                        iconName = 'book-open';
                        break;
                    case 'Libraries':
                        return <FontAwesomeIcon name='university' size={25} color={tintColor} />;
                    case 'Reservations':
                        iconName = 'shopping-bag';
                        break;
                    case 'Account':
                        iconName = 'user';
                        break;
                    case 'Server':
                        iconName = 'server';
                        break;
                }

                // You can return any component that you like here!
                return <IconComponent name={iconName} size={25} color={tintColor} />;
            }
        }),
        tabBarOptions: {
            activeTintColor: PrimaryColor,
            labelStyle: {
                fontSize: 13,
            },
            showIcon: true
        }
    });

const AppContainer = createAppContainer(
    createSwitchNavigator({
        Loading: LoadingScreen,
        Auth: authNavigator,
        App: tabNavigator
    })
);


class App extends React.Component {

    componentDidMount() {
        // Load the logged user
    }

    render() {
        return (
            <Provider
                authStore={authStore}
                userStore={userStore}
            >
                <AppContainer />
            </Provider>
        )
    }
}

/*BookScreen.navigationOptions = {
   header: (
       <View>
           <SearchBar lightTheme={true}/>
       </View>
   )
};*/

export default App;
