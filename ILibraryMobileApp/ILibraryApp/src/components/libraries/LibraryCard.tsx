import * as React from "react";
import {LibraryViewModel} from "../../models/LibraryModels";
import {StyleSheet, Text, TouchableOpacity, View} from "react-native";
import Utility from "../../utils/Utility";
import Icon from 'react-native-vector-icons/Feather'


interface IProps {
    library: LibraryViewModel
}

export default class LibraryCard extends React.Component<IProps> {
    render() {
        const library = this.props.library;
        return (
            <TouchableOpacity>
                {Utility.getImage(library.profileUri)}
                <Text numberOfLines={1} style={styles.itemName}>{library.name}</Text>
                <View style={{flexDirection: 'row'}}>
                    <Icon name='map-pin' size={25} />
                    <Text style={styles.itemCode} numberOfLines={1}>
                        {library.address}
                    </Text>
                </View>
            </TouchableOpacity>
        )
    }
}

const styles = StyleSheet.create({
    itemContainer: {
        justifyContent: 'flex-end',
        borderRadius: 5,
        padding: 10,
        height: 130
    },
    itemName: {
        fontSize: 13,
        color: 'black',
        fontWeight: '600',
    },
    itemCode: {
        fontWeight: '600',
        fontSize: 10,
        color: '#000',
        marginLeft: 5
    },
    imageBackground: {
        width: '100%',
        height: '100%',
        borderRadius: 10,
    }
});