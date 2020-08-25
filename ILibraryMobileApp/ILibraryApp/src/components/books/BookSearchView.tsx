import * as React from "react";
import { View, Text, RefreshControl, StyleSheet, TouchableOpacity } from "react-native";
import { Divider } from "react-native-elements";
import { BookViewModel } from "../../models/BookModels";
import { TextInput } from "react-native-gesture-handler";
import { FlatGrid } from "react-native-super-grid";
import BookCard from "./BookCard";
import { NavigationStackProp } from "react-navigation-stack";
import Icon from 'react-native-vector-icons/Feather'
import { BookService } from "../../services/BookService";


interface IProps {
    navigation: NavigationStackProp
}

interface IState {
    isSearching: boolean,
    searchTerm: string,
    books: BookViewModel[]
}

export default class BookSearchView extends React.Component<IProps, IState> {

    constructor(props: IProps) {
        super(props);
        this.state = {
            isSearching: false,
            searchTerm: '',
            books: []
        }
    }

    setSearchTerm(txt: string) {
        this.setState({ searchTerm: txt });
    }

    search = () => {
        console.log("searching...")
        BookService.getBooks({
            name: this.state.searchTerm
        }).then((result) => {
            this.setState({ books: result.data });
        }).catch(() => {

        }).finally(() => {

        })
    }

    render() {
        const books = this.state.books;
        return (
            <>
                <View style={styles.topBar}>
                    <TouchableOpacity
                        onPress={() => {
                            this.props.navigation.goBack();
                        }}
                    >
                        <Icon name="arrow-left" size={22} style={styles.icon} />
                    </TouchableOpacity>
                    <TextInput
                        style={{
                            width: '80%',
                            fontSize: 18,
                            marginLeft: 10
                        }}
                        onChangeText={value => this.setSearchTerm(value)}
                        placeholder='Search term'
                    />
                    <TouchableOpacity
                        onPress={this.search}
                    >
                        <Icon name="search" size={22} style={styles.icon} />
                    </TouchableOpacity>
                </View>
                <Text style={{ fontSize: 20, marginTop: 10, fontWeight: 'bold' }}> Result</Text>
                <Divider style={{ marginTop: 5 }} />

                <FlatGrid
                    itemDimension={100}
                    items={books}
                    style={styles.gridView}
                    refreshControl={
                        <RefreshControl
                            refreshing={this.state.isSearching}
                            onRefresh={() =>
                                this.search()
                            }
                        />
                    }
                    renderItem={({ item, index }) => (
                        <BookCard book={item} navigation={this.props.navigation} />
                    )}
                />
            </>
        )
    }
}

const styles = StyleSheet.create({
    topBar: {
        flexDirection: 'row',
        borderRadius: 1,
        elevation: 3,
    },
    searchBox: {

    },
    icon: {
        marginTop: 15,
        marginLeft: 5
    },
    gridView: {
        marginTop: 20,
        flex: 1
    },
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
    },
    imageBackground: {
        width: '100%',
        height: '100%',
        borderRadius: 10,
    }
});
