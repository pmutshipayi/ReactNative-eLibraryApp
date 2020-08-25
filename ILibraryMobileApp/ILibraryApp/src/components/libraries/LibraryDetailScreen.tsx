import React from "react";
import { View, Text, RefreshControl, StyleSheet } from "react-native";
import { NavigationStackProp } from "react-navigation-stack";
import Utility from "../../utils/Utility";
import LibraryProfileCard from "./LibraryProfileCard";
import { LibraryViewModel } from "../../models/LibraryModels";
import { Divider } from "react-native-elements";
import { BookViewModel } from "../../models/BookModels";
import { FlatGrid } from "react-native-super-grid";
import BookCard from "../books/BookCard";
import { BookService } from "../../services/BookService";


interface IProps {
    navigation: NavigationStackProp
}

interface IState {
    isLoading: boolean,
    books: BookViewModel[]
}

export default class LibraryDetailScreen extends React.Component<IProps, IState> {

    static navigationOptions = ({ navigation }) => {
        return ({
            title: Utility.firstToUppercase(navigation.getParam("library", "").name)
        });
    };

    library: LibraryViewModel;

    constructor(props: IProps) {
        super(props);
        this.state = {
            isLoading: false,
            books: []
        }
        const { navigation } = this.props;
        this.library = navigation.getParam("library", "");
    }

    componentDidMount() {
        this.loadBooks();
    }

    loadBooks() {
        if (this.state.isLoading)
            return;
        this.setState({ isLoading: true });
        BookService.getBooks({
            libraryId: this.library.id
        })
            .then((result) => {
                this.setState({ books: result.data });
                console.log("c : " + result.data.length)
            })
            .catch(() => {
                // err
                
            })
            .finally(() => {
                this.setState({isLoading: false})
            })
    }

    render() {
        const books = this.state.books;
        return (
            <>
                <LibraryProfileCard library={this.library} />
                <Divider />
                <Text style={{ fontSize: 22, fontWeight: 'bold' }}> Books </Text>
                <FlatGrid
                    itemDimension={100}
                    items={books}
                    style={styles.gridView}
                    refreshControl={
                        <RefreshControl
                            refreshing={this.state.isLoading}
                            onRefresh={() =>
                                this.loadBooks()
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
