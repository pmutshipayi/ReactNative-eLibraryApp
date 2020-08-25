import * as React from "react";
import { BookViewModel } from "../../models/BookModels";
import BookUI from "./BookUI";
import { StyleSheet, Text, TouchableOpacity } from "react-native";

interface IProps {
    book: BookViewModel,
    navigation: any,
    navigationPush?: boolean
}

export default class BookCard extends React.Component<IProps> {

    render() {
        return (
            <TouchableOpacity
                style={[styles.itemContainer]}
                onPress={() => {
                    if (this.props.navigationPush) {
                        this.props.navigation.push('Detail', {
                            book: this.props.book
                        })
                    }
                    else {
                        this.props.navigation.navigate('Detail', {
                            book: this.props.book
                        });
                    }
                }}>
                {BookUI.getBookProfile(this.props.book)}
                <Text numberOfLines={1} style={styles.itemName}>{this.props.book.name}</Text>
                <Text style={styles.itemCode}>{this.props.book.isAvailable ? 'available' : 'not available'}</Text>
            </TouchableOpacity>
        )
    }
}

const styles = StyleSheet.create({
    itemContainer: {
        justifyContent: 'flex-end',
        borderRadius: 5,
        padding: 10,

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
    },
    imageBackground: {
        width: '100%',
        height: '100%',
        borderRadius: 10,
    }
});