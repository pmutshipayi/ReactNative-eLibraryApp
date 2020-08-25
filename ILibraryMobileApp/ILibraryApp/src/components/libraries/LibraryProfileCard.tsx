import * as React from "react";
import {LibraryViewModel} from "../../models/LibraryModels";
import {Text, View, StyleSheet} from "react-native";
import Utility from "../../utils/Utility";
import Icon from 'react-native-vector-icons/Feather'
import {default as FontAwesome} from 'react-native-vector-icons/FontAwesome'
import BookUI from "../books/BookUI";

interface IProps {
    library: LibraryViewModel
}

export default class LibraryProfileCard extends React.Component<IProps> {

    render() {
        const library = this.props.library;
        let emails;
        let phones;
        let address;
        if (library.emailAddress2 || library.emailAddress) {
            emails = <View>
                <View style={styles.infoTitleView}>
                    <Icon name='mail' size={20}/>
                    <Text style={styles.infoTitle}>Email</Text>
                </View>
                <View style={styles.infoContent}>
                    {Utility.displayTextIfExist(library.emailAddress)}
                    {Utility.displayTextIfExist(library.emailAddress2)}
                </View>
            </View>
        }
        if (library.phone || library.phone2) {
            phones = <View>
                <View style={styles.infoTitleView}>
                    <Icon name='phone' size={20}/>
                    <Text style={styles.infoTitle}>Phones</Text>
                </View>
                <View style={styles.infoContent}>
                    {Utility.displayTextIfExist(library.phone)}
                    {Utility.displayTextIfExist(library.phone2)}
                </View>
            </View>
        }
        if (library.address){
            address = <View>
                <View style={styles.infoTitleView}>
                    <Icon name='map-pin' size={20}/>
                    <Text style={styles.infoTitle}>Address</Text>
                </View>
                <View style={styles.infoContent}>
                    <Text>{library.address}</Text>
                </View>
            </View>
        }
        return (
            <View>
                <View style={{flexDirection: 'row'}}>
                    <View style={{padding: 5, marginLeft: 10}}>
                        <Text
                            style={{fontSize: 18, fontWeight: 'bold'}}>
                            {Utility.firstToUppercase(library.name)}
                        </Text>
                        <View style={{marginTop: 10}}>
                            {emails}
                            {phones}
                            {address}
                        </View>
                    </View>
                </View>
            </View>
        )
    }
}

const styles = StyleSheet.create({
    infoTitleView: {
        marginLeft: 10,
        marginTop: 10,
        flexDirection: 'row'
    },
    infoTitle: {
        marginLeft: 5,
        fontWeight: 'bold'
    },
    infoContent: {
        marginLeft: 35
    }
});