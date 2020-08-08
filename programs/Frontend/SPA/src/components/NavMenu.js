import * as React from 'react';
import SignIn from './SignIn';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component {
    render() {
        return  <div className='main-nav'>
            <div className='navbar navbar-inverse'>
                <div className='navbar-header'>
                    <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                        <span className='sr-only'>Toggle navigation</span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                    </button>
                    <Link className='navbar-brand' to={ '/' }>ReactReduxTemplate</Link>
                    <SignIn/>
                </div>
                <div className='clearfix'></div>
                <div className='navbar-collapse collapse'>
                    <ul className='nav navbar-nav'>
                        <li>
                            <NavLink exact to={ '/' } activeClassName='active'>
                                <span className='glyphicon glyphicon-home'></span> Home
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={ '/counter' } activeClassName='active'>
                                <span className='glyphicon glyphicon-education'></span> Counter
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={ '/fetchdata' } activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Fetch data
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={ '/crudsample' } activeClassName='active'>
                                <span className='glyphicon glyphicon-modal-window'></span> Crud sample
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={ '/crudsample2' } activeClassName='active'>
                                <span className='glyphicon glyphicon-modal-window'></span> Crud sample2
                            </NavLink>
                        </li>
                    </ul>
                </div>
            </div>
        </div>;
    }
}