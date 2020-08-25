import {Text, View} from "react-native";
import React from "react";
import FontAwesome5Icon from "react-native-vector-icons/FontAwesome5";
import Icon from "react-native-vector-icons/MaterialCommunityIcons";

class ReservationScreen extends React.Component{
    render(){
        return (
            <View>
                <Text>Reservation updated again.</Text>
                <Icon name="account" size={30} color="green"/>
            </View>
        )
    }
}
export default ReservationScreen;