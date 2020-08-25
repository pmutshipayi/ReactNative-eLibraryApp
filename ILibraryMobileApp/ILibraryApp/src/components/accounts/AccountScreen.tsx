import { Text, View } from "react-native";
import React from "react";
import { ListItem } from "react-native-elements";
import { inject, observer } from "mobx-react";
import authStore from '../../stores/AuthStore'
import { NavigationStackProp } from "react-navigation-stack";
import { NavigationActions, StackActions } from "react-navigation";
import NavigationService from "../../services/NavigationService";

interface IProps {
    navigation: NavigationStackProp,
    // @ts-ignore
    authStore: AuthStore
}

class AccountScreen extends React.Component<IProps> {

    constructor(props: IProps) {
        super(props)
    }

    handlePress = (title: string) => {
        switch (title) {
            case 'Profile':
                this.props.navigation.navigate('Profile');
                break;
            case 'Logout':
                this.props.authStore.logout();
                this.props.navigation.navigate("Login")
        }
    };

    render() {
        const list = [
            {
                title: 'Profile',
                icon: 'person'
            },
            /*{
                title: 'Change password',
                icon: 'flight-takeoff'
            },
            {
               title: 'Delete my account',
               icon: 'remove'
            },*/
            {
                title: 'Logout',
                icon: 'exit-to-app'
            }
        ];

        return (
            <View>
                {
                    list.map((item, i) => (
                        <ListItem
                            key={i}
                            title={item.title}
                            leftIcon={{ name: item.icon }}
                            bottomDivider
                            chevron
                            onPress={(e) => {
                                this.handlePress(item.title)
                            }}
                        />
                    ))
                }
            </View>
        )
    }
}
export default inject('authStore')(observer(AccountScreen));